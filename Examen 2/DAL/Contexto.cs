using Examen_2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Examen_2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vehiculos> vehiculo { get; set; }
        public DbSet<Talleres> taller { get; set; }
        public DbSet<EntradaArticulos> entradaArticulo {get; set; }
        public DbSet<Articulos> articulo { get; set; }
        public DbSet<Mantenimientos> mantenimiento { get; set; }

        public DbSet<MantenimientosDetalle> Detalles { get; set; }
        public Contexto() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
