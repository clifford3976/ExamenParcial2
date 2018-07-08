using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Examen_2.Entidades
{
    public class Articulos
    {
        [Key]

        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal Ganancia { get; set; }
        public decimal precio { get; set; }
        public decimal Inventario { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Descripcion = string.Empty;
            this.costo = 0;
            Ganancia = 0;
            precio = 0;
            Inventario = 0;
        }



        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
