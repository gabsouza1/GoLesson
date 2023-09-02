using Application.Apps;
using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaApp _categoriaApp;
        private readonly ILogger<CategoriaController> _logger;

        public CategoriaController(ILogger<CategoriaController> logger, ICategoriaApp categoriaApp)
        {
            _categoriaApp = categoriaApp;
            _logger = logger;
        }

        // GET: CategoriaController
        public async Task<IActionResult> Index()
        {
            var categoria = await _categoriaApp.GetAllAsync();
            return View(categoria);
        }

        // GET: CategoriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(CategoriaViewModel collection)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View("create", collection);
                }
                await _categoriaApp.AddAsync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var edit = await _categoriaApp.GetByIdAsync(id);
            return View(edit);
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveEdit(int id, CategoriaViewModel collection)
        {
            try
            {
                if(!ModelState.IsValid || id == 0)
                {
                    return View("Edit", collection);

                }

                await _categoriaApp.UpdateAsync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _categoriaApp.GetByIdAsync(id);
            return View(delete);
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItem(int id, CategoriaViewModel collection)
        {
            try
            {
                var delete = await _categoriaApp.GetByIdAsync(id);
                if (id != delete.Id) 
                {
                    return BadRequest();
                }
                _categoriaApp.Remove(delete.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                
                return View();
            }
        }
    }
}
