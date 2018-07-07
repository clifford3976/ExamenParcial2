﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Examen_2.Entidades
{
    public class Talleres
    {
        [Key]
        public int TallerId { get; set; }
        public string Nombre { get; set; }

        public Talleres()
        {
            TallerId = 0;
            Nombre = string.Empty;
        }
    }
}
