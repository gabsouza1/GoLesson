using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace UI.Controllers
{
    [Authorize]
    public class CursosController : Controller
    {
        private readonly ICategoriaApp _categoriaApp;
        private readonly INivelEscolaridadeApp _nivelEscolaridadeApp;
        private readonly ICursoApp _cursoApp;

        public CursosController(ICategoriaApp categoriaApp, INivelEscolaridadeApp nivelEscolaridadeApp
            , ICursoApp cursoApp)
        {
            _categoriaApp = categoriaApp;
            _nivelEscolaridadeApp = nivelEscolaridadeApp;
            _cursoApp = cursoApp;
        }

        [AllowAnonymous]
        // GET: CursosController
        public async Task<IActionResult> Index(int? pagina)
        {
            int numeroPagina = pagina ?? 1;
            int totalItem = 9;
            var cursos = await _cursoApp.GetAllAsync();
            IPagedList<CursoViewModel> cursoPagina = cursos.ToPagedList(numeroPagina, totalItem);
            return View(cursoPagina);
        }

        [Authorize(Roles = "Aluno")]
        public IActionResult MeusCursos()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Professor")]
        public async Task<IActionResult> MeuCurso(int id)
        {
            var cursos = await _cursoApp.GetCursosByTeacher(id);
            if(cursos.Count > 0)
            {
                return View(cursos);
            }
            else
            {
                return View();
            }

        }

        // GET: CursosController/Details/5
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var curso = await _cursoApp.GetByIdAsync(id);
            return View(curso);
        }

        [Authorize(Roles = "Professor")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categorias = await _categoriaApp.GetAllAsync();
            return View();
        }

        [Authorize(Roles = "Professor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CursoViewModel cursoViewModel)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //public ActionResult MeusCursos (int id) { }
    }
}
