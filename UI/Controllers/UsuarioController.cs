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

        public UsuarioController(UserManager<Usuario> userManager) 
        {
            _userManager = userManager;
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
    }
}
