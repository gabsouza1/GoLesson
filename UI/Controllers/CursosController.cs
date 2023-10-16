using Application.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<Usuario> _userManager;

        public CursosController(ICategoriaApp categoriaApp, INivelEscolaridadeApp nivelEscolaridadeApp
            , ICursoApp cursoApp, UserManager<Usuario> userManager)
        {
            _categoriaApp = categoriaApp;
            _nivelEscolaridadeApp = nivelEscolaridadeApp;
            _cursoApp = cursoApp;
            _userManager = userManager;
        }

        [AllowAnonymous]
        // GET: CursosController
        public async Task<IActionResult> Index()
        {
            var cursos = await _cursoApp.GetAllAsync();
            return View(cursos);
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
            return View(cursos);
        }

        // GET: CursosController/Details/5
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var curso = await _cursoApp.GetByIdAsync(id);
            var user = _userManager.FindByEmailAsync(User.Identity.Name).Result;

            curso.HasCurso = user.Compras.Where(a=> a.CursoId == curso.Id).Count() > 0;

            return View(curso);
        }

        [Authorize(Roles = "Professor")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categorias = await _categoriaApp.GetAllAsync();
            ViewBag.Nivel = await _nivelEscolaridadeApp.GetAllAsync();
            return View();
        }

        [Authorize(Roles = "Professor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CursoViewModel cursoViewModel, IFormFile capa, string[] lista)
        {
            try
            {
                cursoViewModel.Materias = new List<string>();
                foreach (string str in lista.Where(x => !string.IsNullOrEmpty(x)))
                {
                    string strSemChar = str.Replace("\"", "").Replace("[", "").Replace("]", "");
                    string[] elements = strSemChar.Split(',');

                    foreach (string element in elements)
                    {
                        cursoViewModel.Materias.Add(element);
                    }
                }

                if (!ModelState.IsValid)
                {
                    ViewBag.Categorias = await _categoriaApp.GetAllAsync();
                    ViewBag.Nivel = await _nivelEscolaridadeApp.GetAllAsync();
                    return View("Create", cursoViewModel);
                }
                if (capa != null)
                {
                    cursoViewModel.Capa = capa.FileName;
                }
                var result = await _cursoApp.AddCursoAsync(cursoViewModel);
                if (result.Id != 0)
                {
                    if (result.Capa != null)
                    {
                        Upload(capa);
                    }
                    return RedirectToAction("Index", "Home");

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Categorias = await _categoriaApp.GetAllAsync();
                ViewBag.Nivel = await _nivelEscolaridadeApp.GetAllAsync();
                return View("Create", cursoViewModel);
            }
        }

        [Authorize(Roles = "Professor")]
        [HttpGet]
        // GET: CursosController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var edit = await _cursoApp.GetByIdAsync(id);
            ViewBag.Categorias = await _categoriaApp.GetAllAsync();
            ViewBag.Nivel = await _nivelEscolaridadeApp.GetAllAsync();
            return View(edit);
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

        public string Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {

                var nomeArquivo = file.FileName;

                // Caminho onde você deseja salvar o arquivo
                var caminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Resources\\Capas", nomeArquivo);

                // Copie o arquivo para o caminho desejado
                using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // Realize qualquer ação adicional com o arquivo, se necessário

                return "Inserido";
            }
            return "Falha";
        }

        [Authorize(Roles = "Aluno")]
        [HttpGet]
        public async Task<IActionResult> MyCourses(int id)
        {
            var cursos = await _cursoApp.GetCursosByStudent(id);
            return View(cursos);
        }

        [Authorize(Roles = "Aluno")]
        [HttpPost]
        public async Task<IActionResult> BuyCourses(int cursoId, int usuarioId)
        {
            try
            {
                var result = await _cursoApp.BuyCourse(cursoId, usuarioId);

                if (result.Id != 0)
                {

                    return RedirectToAction("MyCourses", new RouteValueDictionary { { "id", cursoId }});
                }
                else
                {
                    ModelState.AddModelError("", "Erro ao efetuar a compra, tente novamente mais tarde");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Erro ao efetuar a compra, tente novamente mais tarde");
            }
            return View(MyCourses(cursoId));
        }
    }
}
