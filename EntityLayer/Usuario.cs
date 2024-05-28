using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Usuario
    {
        //Datos de nuestra tabla en BDD
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
