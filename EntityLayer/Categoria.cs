﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Categoria
    {
        //Datos de nuestra tabla en BDD
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
