using CRUD_ENTITY_FRAMEWORK_CORE.Context;
using CRUD_ENTITY_FRAMEWORK_CORE.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CRUD_ENTITY_FRAMEWORK_CORE.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;

        }

        public IActionResult Logar()
        {
            return View();
        }


        [HttpPost, ActionName("Logar")]
        [HttpPost]
        public async Task <IActionResult> LogarEfetivamente(UserModel userModel)
        {
            if (userModel == null)
            {
                return RedirectToAction("Logar");
            }

            else if (VerificarExistenciaDoUsuario(userModel) == false)
            {
                return View();
            }
            var userModelPermissao = _context.UserModel
                .Where(user => user.UserName == userModel.UserName)
                .ToList<UserModel>();

            return await AdicionarCookie(userModelPermissao);
        }

        public bool VerificarExistenciaDoUsuario(UserModel userModel)
        {
            var usuario = _context.UserModel.
                Where(user => user.UserName == userModel.UserName && user.Password == userModel.Password) ;
            if(usuario.Count() == 0)
            {
                ViewBag.Notification = "Usuário não registrado.";
                return false;
            }
            return true;
        }

        public async Task<IActionResult> AdicionarCookie(List<UserModel> userModel)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userModel[0].UserName),
                new Claim(ClaimTypes.Role, userModel[0].Permissao),
                new Claim(ClaimTypes.Name, userModel[0].UserName)
            };
            var userIdentity = new ClaimsIdentity(claims, "DefaultSchemeCookieCRUD");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            return Redirect("/Livros/Index");
        }
    }
}
