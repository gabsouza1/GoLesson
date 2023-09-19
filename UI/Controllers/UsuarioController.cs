using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly IMapper _mapper;
        public UsuarioController(UserManager<Usuario> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        // GET: UsuárioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuárioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuárioController/Create
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

        // GET: UsuárioController/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            UsuarioViewModel viewModel = _mapper.Map<UsuarioViewModel>(_userManager.FindByIdAsync(Convert.ToString(id)));
            return View(viewModel);
        }

        // POST: UsuárioController/Edit/5
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

        // GET: UsuárioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuárioController/Delete/5
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
