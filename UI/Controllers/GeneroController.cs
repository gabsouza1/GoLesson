using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class GeneroController : Controller
    {
        private readonly IGeneroApp _generoApp;
        private readonly ILogger<GeneroController> _logger;
        public GeneroController(ILogger<GeneroController> logger, IGeneroApp generoApp)
        {
            _generoApp = generoApp;
            _logger = logger;
        }
        // GET: GeneroController
        public async Task<IActionResult> Index()
        {
            var generos = await _generoApp.GetAllAsync();
            return View(generos);
        }

        // GET: GeneroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GeneroController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(GeneroViewModel collection)
        {
            try
            {
                if(!ModelState.IsValid)
                { 
                    return View("Create", collection);
                }

                await _generoApp.AddAsync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneroController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            GeneroViewModel generoViewModel = new();
            var edit = await _generoApp.GetByIdAsync(id) ?? generoViewModel;
            if(edit == generoViewModel)
            {
                return BadRequest();
            }
            return View(edit);
        }

        // POST: GeneroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveEdit(int id, GeneroViewModel collection)
        {
            try
            {
                if (!ModelState.IsValid  || id == 0)
                {
                    return View("Edit", collection);
                }

                await _generoApp.UpdateAsync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneroController/Delete/5
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
