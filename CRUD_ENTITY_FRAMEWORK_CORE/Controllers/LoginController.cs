using CRUD_ENTITY_FRAMEWORK_CORE.Context;
using CRUD_ENTITY_FRAMEWORK_CORE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Logar(UserModel userModel)
        {
            if (userModel == null)
            {
                return RedirectToAction("Logar");
            }

            else if (VerificarExistenciaDoUsuario(userModel) == false)
            {
                return View();
            }
            return Redirect("/Livros/Index");

        }

        public bool VerificarExistenciaDoUsuario(UserModel userModel)
        {
            var usuario = _context.UserModel.
                Where(user => user.UserName == userModel.UserName && user.Password == userModel.Password) ;
            if(usuario.Count() == 0)
            {
                ViewBag.Notification = "Não Existe";
                return false;
            }
            return true;
        }
    }
}
