using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public LoginController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }



    }
}
