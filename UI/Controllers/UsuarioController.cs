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

        public UsuarioController(UserManager<Usuario> userManager, IGeneroApp generoApp) 
        {
            _userManager = userManager;
            _generoApp = generoApp;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> TeacherIndex()
        {
            ViewBag.Generos = await _generoApp.GetAllAsync();
            return View();
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
