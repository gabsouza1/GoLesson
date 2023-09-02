using Application.Apps;
using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class StatusPagamentoController : Controller
    {
        private readonly IStatusPagamentoApp _statuspagamentoApp;
        private readonly ILogger<StatusPagamentoController> _logger;

        public StatusPagamentoController(ILogger<StatusPagamentoController> logger, IStatusPagamentoApp statuspagamentoApp)
        {
            _statuspagamentoApp = statuspagamentoApp;
            _logger = logger;
        }

        // GET: StatusPagamentoController
        public async Task<IActionResult> Index()
        {
            var statuspagamento = await _statuspagamentoApp.GetAllAsync();
            return View(statuspagamento);
        }

        // GET: StatusPagamentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatusPagamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatusPagamentoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(StatusPagamentoViewModel collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("create", collection);
                }
                await _statuspagamentoApp.AddAsync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StatusPagamentoController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var edit = await _statuspagamentoApp.GetByIdAsync(id);
            return View(edit);
        }

        // POST: StatusPagamentoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveEdit(int id, StatusPagamentoViewModel collection)
        {
            try
            {
                if (!ModelState.IsValid || id == 0)
                {
                    return View("Edit", collection);

                }

                await _statuspagamentoApp.UpdateAsync(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET:StatusPagamentoController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var delete = await _statuspagamentoApp.GetByIdAsync(id);
            return View(delete);
        }

        // POST: StatusPagamentoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItem(int id, StatusPagamentoViewModel collection)
        {
            try
            {
                var delete = await _statuspagamentoApp.GetByIdAsync(id);
                if (id != delete.Id)
                {
                    return BadRequest();
                }
                _statuspagamentoApp.Remove(delete.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }
    }
}
