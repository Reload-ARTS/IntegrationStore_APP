using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Rol
    {
        //Datos de nuestra tabla en BDD
        public int IdRol { get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; }
    }
}
