using PrimeraExpo.DA.Configuration;
using PrimeraExpo.DA.Entities;
using PrimeraExpo.ViewModels.PersonaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraExpo.Controllers
{
    public class PersonaController : Controller
    {
        #region Get Methods

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Lista()
        {
            var model = new ListaViewModel();
            using (PrimeraExpoContext db = new PrimeraExpoContext())
            {
                model.Personas = db.Personas.ToList();
            }
            return View(model);

        }

        public ActionResult Detalles(int id)
        {
            PrimeraExpoContext db = new PrimeraExpoContext();

            var model = new DetallesViewModel();
            model.Persona = db.Personas.SingleOrDefault(persona => persona.PersonaId == id);
            return View(model);
        }

        #endregion

        #region Post Methods

        [HttpPost]
        public ActionResult Registrar(RegistrarViewModel model)
        {
            using (PrimeraExpoContext db = new PrimeraExpoContext())
            {
                var persona = new Persona
                {
                    Nombre = model.Nombre,
                    Apellidos = model.Apellidos,
                    Edad = model.Edad,
                    Correo = model.Correo,
                    Contrasenna = model.Contrasenna
                };
                db.Personas.Add(persona);
                db.SaveChanges();
                ViewBag.Confirmacion = "Registro completado!";
            }
            return View();
        }
        #endregion
    }
}