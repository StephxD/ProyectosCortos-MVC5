using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01_LoginMVC.Models;


namespace Lab01_LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult Login(string usuario, string password)
        {
            
            try
            {
                using (LoginMVCEntities db = new LoginMVCEntities())
                {
                    var lista = from u in db.users
                                where u.usuario == usuario
                                && u.password == password
                                && u.activo == "A"
                                select u;

                    if (lista.Count() > 0)
                    {
                        user myUser = lista.First();
                        return Content("usuario valido");
                    }
                    else
                        return Content("Usuario Invalido");

                }
            }
            catch (Exception ex) {

                return Content("Ocurrió un error: " + ex.Message);
            }

           
        }
    }
}