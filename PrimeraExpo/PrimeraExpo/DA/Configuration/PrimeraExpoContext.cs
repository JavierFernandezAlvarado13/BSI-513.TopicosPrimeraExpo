using PrimeraExpo.DA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimeraExpo.DA.Configuration
{
    public class PrimeraExpoContext : DbContext
    {
        public PrimeraExpoContext() : base("TopicosDB")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Previene que la tabla de la base de datos sea pluralizada. Ej: (Persona => Personas)
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}