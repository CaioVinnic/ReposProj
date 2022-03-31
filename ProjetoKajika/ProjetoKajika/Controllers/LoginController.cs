using ProjetoKajika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace ProjetoKajika.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult Autentica(UsuarioModel model)
        {
            if (!String.IsNullOrEmpty(model.Nome) && !String.IsNullOrEmpty(model.Senha))
            {
                if (WebSecurity.Login(model.Nome, model.Senha))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("login.Invalido", "Login ou senha incorretos");
                    return View("SignIn");
                }
            }
            else
            {
                return View("SignIn");
            }

        }
        public ActionResult Logout()
        {
            WebSecurity.Logout();
            return RedirectToAction("SignIn", "Login");
        }
    }
}