using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Permiso
    {
        //Datos de nuestra tabla en BDD
        public int IdPermiso { get; set; }
        public Rol oRol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
