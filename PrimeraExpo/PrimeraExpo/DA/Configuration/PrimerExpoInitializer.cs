using PrimeraExpo.DA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimeraExpo.DA.Configuration
{
    public class PrimerExpoInitializer : DropCreateDatabaseIfModelChanges<PrimeraExpoContext>
    {
        protected override void Seed(PrimeraExpoContext context)
        {
            var personas = new List<Persona>
            {
                new Persona {Nombre = "Rafael", Apellidos = "Marquez", Edad = 36, Correo = "Rafael.Marquez@hotmail.com", Contrasenna = "rafa123456" },
                new Persona {Nombre = "Gustavo", Apellidos = "Pedregal", Edad = 20, Correo = "Gustavo.Pedregal@hotmail.com", Contrasenna = "tavo123456" },
                new Persona {Nombre = "Gloriana", Apellidos = "Valverde", Edad = 18, Correo = "Gloriana.Valverde@hotmail.com", Contrasenna = "glori123456" },
                new Persona {Nombre = "Jonathan", Apellidos = "Jordan", Edad = 22, Correo = "Jonathan.Jordan@hotmail.com", Contrasenna = "jona123456" },
                new Persona {Nombre = "Michael", Apellidos = "Gonzalez", Edad = 28, Correo = "Michael.Gonzalez@hotmail.com", Contrasenna = "mika123456" },
                new Persona {Nombre = "Eduardo", Apellidos = "Florentino", Edad = 30, Correo = "Eduardo.Florentino@hotmail.com", Contrasenna = "ed123456" }
            };
            personas.ForEach(persona => context.Personas.Add(persona));

            var facturas = new List<Factura> {
                new Factura { Descripcion = "Compra de combustible.", Precio = 2000.00, Persona = personas[0]},
                new Factura { Descripcion = "Compra de ropa.", Precio = 1000.00, Persona = personas[0]},
                new Factura { Descripcion = "Compra de alimentos.", Precio = 500.00, Persona = personas[0]},
            };
            facturas.ForEach(factura => context.Facturas.Add(factura));

            context.SaveChanges();
            InitializeDatabase(context);
        }
    }
}