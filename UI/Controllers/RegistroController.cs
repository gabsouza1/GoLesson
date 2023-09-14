using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IUsuarioApp _usuarioApp;

        public RegistroController(IUsuarioApp usuarioApp)
        {
            _usuarioApp = usuarioApp;
        }


        // GET: RegistroController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegistroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegistroViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Preencha os campos  corretamente");
                    return View(nameof(Index), model);
                }

                var result = await _usuarioApp.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroController/Edit/5
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

        // GET: RegistroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroController/Delete/5
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
    }
}
