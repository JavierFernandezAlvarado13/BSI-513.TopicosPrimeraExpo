using PrimeraExpo.DA.Configuration;
using System;
using PrimeraExpo.DA.Entities;
using System.Collections.Generic;
using PrimeraExpo.ViewModels.FacturaViewModels;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimeraExpo.Controllers
{
    public class FacturaController : Controller
    {
        #region Get Methods

        public ActionResult Crear()
        {
            var model = new CrearViewModel();
            using (PrimeraExpoContext db = new PrimeraExpoContext())
            {
                var lista = new List<SelectListItem>();
                var personas = db.Personas.ToList();
                foreach (var persona in personas)
                {
                    lista.Add(new SelectListItem() { Value = persona.PersonaId.ToString(), Text = persona.Nombre + " " + persona.Apellidos });
                }
                model.ListaItems = lista;
            }
            return View(model);
        }

        #endregion

        #region Post Methods

        [HttpPost]
        public ActionResult Crear(CrearViewModel model)
        {
            using (PrimeraExpoContext db = new PrimeraExpoContext())
            {
                var Persona = db.Personas.SingleOrDefault(persona => persona.PersonaId == model.PersonaId);
                var Factura = new Factura
                {
                    Descripcion = model.Descripcion,
                    Precio = model.Precio,
                    Persona = Persona
                };
                db.Facturas.Add(Factura);
                db.SaveChanges();
                ViewBag.Confirmacion = "Factura creada";
                return View();
            }
        }
        #endregion
    }
}