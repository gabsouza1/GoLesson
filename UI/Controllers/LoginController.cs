using Application.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly ILogger<Usuario> _logger;
        public LoginController(UserManager<Usuario> userManager, ILogger<Usuario> logger, SignInManager<Usuario> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try 
            {
                if(ModelState.IsValid) 
                {
                    var isAuthenticated = await _signInManager.PasswordSignInAsync(model.Email, model.Senha, model.LembrarDeMim, false);

                    if(isAuthenticated.Succeeded) 
                    {
                        ViewData["Sucesso"] = "Login Efetuado";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email ou Senha incorretos");
                    }
                }
                return View("Index", model); 
            }catch (Exception ex)
            {
                return View("Index");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }




    }
}
