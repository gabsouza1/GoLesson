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
        private readonly SignInManager<Usuario> _signInManager;

        public UsuarioController(UserManager<Usuario> userManager, IGeneroApp generoApp,
            IUsuarioApp usuarioApp, SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _generoApp = generoApp;
            _usuarioApp = usuarioApp;
            _signInManager = signInManager;
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
        public async Task<IActionResult> CreateStudent(RegistroViewModel model, IFormFile imagem)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Generos = await _generoApp.GetAllAsync();
                    ModelState.AddModelError("", "Preencha os campos  corretamente");
                    return View("StudentIndex", model);
                }
                if (imagem != null)
                {
                    model.Foto = imagem.FileName;
                }
                var result = await _usuarioApp.AddStudentAsync(model);
                if (result.Id != 0)
                {
                    Upload(imagem);
                    ViewData["Sucessso"] = "Usuário criado com sucesso";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //ViewData["Erro"] = 
                    return View();
                }
            } 
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocorreu um erro no cadastro");
                return View();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTeacher(RegistroViewModel model, IFormFile imagem)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Preencha os campos  corretamente");
                    ViewBag.Generos = await _generoApp.GetAllAsync();
                    return View("TeacherIndex", model);
                }
                if (imagem != null)
                {
                    model.Foto = imagem.FileName;
                }

                var result = await _usuarioApp.AddTeacherAsync(model);
                if (result.Id != 0)
                {
                    Upload(imagem);
                    ViewData["Sucessso"] = "Usuário criado com sucesso";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //ViewData["Erro"] = 
                    return View("Index", "Home");
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
                user.Email = "";
                return View(user);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Aluno, Professor")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(UsuarioViewModel usuarioViewModel, IFormFile? imagem)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Generos = await _generoApp.GetAllAsync();
                    return View("Profile", usuarioViewModel);
                }

                if (imagem != null)
                {
                    Upload(imagem);
                    usuarioViewModel.Foto = imagem.FileName;
                }
                var result = await _usuarioApp.EditProfileAsync(usuarioViewModel);
                await _userManager.UpdateSecurityStampAsync(result);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(result, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Não foi possivel editar o usuário");
                ViewBag.Generos = await _generoApp.GetAllAsync();
                return View(usuarioViewModel);
            }

        }
        public string Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {

                var nomeArquivo = file.FileName;

                // Caminho onde você deseja salvar o arquivo
                var caminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Resources\\Fotos", nomeArquivo);

                // Copie o arquivo para o caminho desejado
                using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // Realize qualquer ação adicional com o arquivo, se necessário

                return "Inserido";
            }
            return "Falha";
        }

        [AllowAnonymous]
        [HttpGet]
        public JsonResult VerificarEmailExistente(string email)
        {
            bool emailExiste = _userManager.Users.Any(u => u.Email == email);
            return Json(!emailExiste);
        }
    }

}
