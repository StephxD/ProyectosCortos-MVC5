using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudiantesCRUD.Models;
namespace EstudiantesCRUD.Controllers
{
    public class EstudianteController : Controller
    {
        PrograVIEntities db = new PrograVIEntities();


        // GET: Estudiante
        public ActionResult Index()
        {

            var estudiante = db.sp_SelectEstudiante();

            return View(estudiante);
        }

        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            var estudiante = db.sp_SelectEstudiantePorID(id.ToString()).First();
            return View(estudiante);
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                db.sp_InsertaEstudiante(collection["id"],
                    collection["nombre"],
                     collection["genero"],
                      collection["direccion"],
                       System.DateTime.Parse(collection["fechaNacimiento"]),
                        collection["celular"],
                       collection["correo"],
                        collection["nacionalidad"]);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                db.sp_UpdateEstudiante(Int32.Parse(collection["idEstudiante"]),
                    id.ToString(),
                  collection["nombre"],
                   collection["genero"],
                    collection["direccion"],
                     System.DateTime.Parse(collection["fechaNacimiento"]),
                      collection["celular"],
                     collection["correo"],
                      collection["nacionalidad"]);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            var estudiante = db.sp_SelectEstudiantePorID(id.ToString()).First();
            return View();
        }

        // POST: Estudiante/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.sp_DeleteEstudiante(id.ToString());

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
