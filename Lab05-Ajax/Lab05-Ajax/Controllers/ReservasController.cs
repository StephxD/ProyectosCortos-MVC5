using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab05_Ajax.Models;
namespace Lab05_Ajax.Controllers
{
    public class ReservasController : Controller
    {
        PrograVIEntities db = new PrograVIEntities();
        // GET: Reservas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AgregarReserva(string pNombre, int pCantidad, string pFecha)
        {
            try
            {
                if (!pNombre.Equals("*"))
                {
                    Reserva myReserva = new Reserva();
                    myReserva.Nombre = pNombre;
                    myReserva.NumPersonas = pCantidad;
                    myReserva.Fecha = pFecha;
                    myReserva.Estado = "A";

                    db.sp_crearReserva(pNombre, pCantidad, pFecha, "A");
                    return PartialView("AgregarReserva", myReserva);
                }

                return PartialView("ReservaAnonima");
            }
            catch (Exception e)
            {
                return PartialView("ReservaAnonima");
            }
        }
    }
}

