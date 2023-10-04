using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [Authorize]
    public class CursosController : Controller
    {
        private readonly ICategoriaApp _categoriaApp;
        private readonly INivelEscolaridadeApp _nivelEscolaridadeApp;

        public CursosController(ICategoriaApp categoriaApp, INivelEscolaridadeApp nivelEscolaridadeApp)
        {
            _categoriaApp = categoriaApp;
            _nivelEscolaridadeApp = nivelEscolaridadeApp;
        }
        [AllowAnonymous]
        // GET: CursosController
        public async Task<IActionResult> Index()
        {
                ViewBag.Categoria = await _categoriaApp.GetAllAsync();
                ViewBag.Nivel = await _nivelEscolaridadeApp.GetAllAsync();
                return View();
        }

        [Authorize(Roles = "Aluno")]
        public IActionResult MeusCursos()
        {
            return View();
        }

        // GET: CursosController/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CursosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
