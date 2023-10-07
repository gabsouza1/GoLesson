using Application.Apps;
using Application.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [Authorize]
    public class UsuarioController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly IGeneroApp _generoApp;
        private readonly IUsuarioApp _usuarioApp;

        public UsuarioController(UserManager<Usuario> userManager, IGeneroApp generoApp, IUsuarioApp usuarioApp)
        {
            _userManager = userManager;
            _generoApp = generoApp;
            _usuarioApp = usuarioApp;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> TeacherIndex()
        {
            ViewBag.Generos = await _generoApp.GetAllAsync();
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> StudentIndex()
        {
            ViewBag.Generos = await _generoApp.GetAllAsync();
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent(RegistroViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Preencha os campos  corretamente");
                    return View(nameof(Index), model);
                }

                var result = await _usuarioApp.AddStudentAsync(model);
                if (result.Id != 0)
                {
                    ViewData["Sucessso"] = "Usuário criado com sucesso";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //ViewData["Erro"] = 
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTeacher(RegistroViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Preencha os campos  corretamente");
                    ViewBag.Generos = await _generoApp.GetAllAsync();
                    return View("TeacherIndex", model);
                }

                var result = await _usuarioApp.AddTeacherAsync(model);
                if (result.Id != 0)
                {
                    ViewData["Sucessso"] = "Usuário criado com sucesso";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //ViewData["Erro"] = 
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Profile(string id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id);
                UsuarioViewModel model = new()
                {
                    Id = user.Id,
                    NomeCompleto = user.NomeCompleto,
                };
                return View(model);
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        //[Authorize(Roles ="Aluno")]
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> MyCourses()
        {
            return View();
        }
    } 

}
