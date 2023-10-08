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
        public async Task<IActionResult> Profile(int id)
        {
            
            try
            {
                ViewBag.Generos = await _generoApp.GetAllAsync();
                var user = await _usuarioApp.GetByIdAsync(id);
                return View(user);
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(UsuarioViewModel usuarioViewModel)
        {
            return View();
        }
        //[Authorize(Roles ="Aluno")]
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> MyCourses()
        {
            return View();
        }


        public string Upload(string fileName)
        {
            var folder = "\\wwwroottt\\Resources";
            return folder; 
        }
    } 

}
