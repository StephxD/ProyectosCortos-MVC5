using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab06_ListasAnidadas.Models;

namespace Lab06_ListasAnidadas.Controllers
{
    public class DireccionController : Controller
    {
        PrograVIEntities db = new PrograVIEntities();
        // GET: Direccion
        public ActionResult Index()
        {
            List<Provincia> ProvinciasList = db.Provincias.ToList();
            ViewBag.ProvinciasList = new SelectList(ProvinciasList, "IdProvincia", "Nombre");
            return View();
        }

        public JsonResult GetCantones(int pIdProvincia)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Canton> cantonList = db.Cantons.Where(x => x.id_Provincia == pIdProvincia).ToList();
            return Json(cantonList, JsonRequestBehavior.AllowGet);
        }

    }
}