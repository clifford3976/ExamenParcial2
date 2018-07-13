using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Examen_2.Entidades
{
    public class EntradaArticulos
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }



        public EntradaArticulos()
        {


            EntradaId = 0;
            Fecha = DateTime.Now;
            ArticuloId = 0;
            Cantidad = 0;
        }



      
    }
}
