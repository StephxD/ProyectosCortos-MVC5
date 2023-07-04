using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02_CRUDPersonas.Models;

namespace Lab02_CRUDPersonas.Controllers
{
    public class PersonasController : Controller
    {
        LoginMVCEntities db = new LoginMVCEntities();
        
        // GET: Personas
        public ActionResult Index()
        {
            var myPerson = db.Personas;

            return View(myPerson);
        }

        // GET: Personas/Details/5
        public ActionResult Details(int id)
        {
            Persona myPerson = (from c in db.Personas
                                where c.id == id
                                select c).First();
            return View(myPerson);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Persona myPerson = new Persona();
                myPerson.IDN = collection["IDN"];
                myPerson.Nombre = collection["Nombre"];
                myPerson.Apellido = collection["Apellido"];
                myPerson.edad = int.Parse(collection["edad"]);
                myPerson.email = collection["email"];
                myPerson.fechaNacimiento = collection["fechaNacimiento"];

                db.Personas.Add(myPerson);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int id)
        {
            Persona myPerson = (from c in db.Personas
                                where c.id == id
                                select c).First();
            return View(myPerson);

           
        }

        // POST: Personas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Persona myPerson = (from c in db.Personas
                                    where c.id == id
                                    select c).First();

                myPerson.IDN = collection["IDN"];
                myPerson.Nombre = collection["Nombre"];
                myPerson.Apellido = collection["Apellido"];
                myPerson.edad = int.Parse(collection["edad"]);
                myPerson.email = collection["email"];
                myPerson.fechaNacimiento = collection["fechaNacimiento"];
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int id)
        {
            Persona myPerson = (from c in db.Personas
                                where c.id == id
                                select c).First();
            return View(myPerson);
        }

        // POST: Personas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Persona myPerson = (from c in db.Personas
                                    where c.id == id
                                    select c).First();

                db.Personas.Remove(myPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
