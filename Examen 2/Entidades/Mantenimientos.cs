using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Examen_2.Entidades
{
    public class Mantenimientos
    {
        [Key]
        public int MantenimientoId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ITBIS { get; set; }
        public decimal Total { get; set; }


        public virtual ICollection<MantenimientosDetalle> Detalle { get; set; }

        public Mantenimientos()
        {
            this.Detalle = new List<MantenimientosDetalle>();

            MantenimientoId = 0;
            Fecha = DateTime.Now;
            Subtotal = 0;
            ITBIS = 0;
            Total = 0;

        }



        public void AgregarDetalle(int id, int mantenimientoId, int tallerId, int articulosId, string articulo, int cantidad, int precio, int importe)
        {
            this.Detalle.Add(new MantenimientosDetalle(id, mantenimientoId, tallerId, articulosId, articulo, cantidad, precio, importe));
        }
    }
}
