using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Examen_2.Entidades
{
    public class MantenimientosDetalle
    {
        [Key]

        public int Id { get; set; }
        public int MantenimientoId { get; set; }
        public int TallerId { get; set; }
        public int ArticulosId { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Importe { get; set; }

        [ForeignKey("ArticulosId")]
        public virtual Articulos Articulos { get; set; }

        public MantenimientosDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
        }

        public MantenimientosDetalle(int id, int mantenimientoId, int tallerId, int articulosId, string articulo, int cantidad, int precio, int importe)
        {
            Id = id;
            MantenimientoId = mantenimientoId;
            TallerId = tallerId;
            ArticulosId = articulosId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }



        public MantenimientosDetalle(int mantenimientoId, int articulosId, string articulo, int cantidad, int precio, int importe)
        {

            MantenimientoId = mantenimientoId;
            ArticulosId = articulosId;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
