using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Cliente
    {
        private DL_Cliente objdl_Cliente = new DL_Cliente();

        public List<Cliente> Listar()
        {
            return objdl_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            //Validaciones
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objdl_Cliente.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            //Validaciones
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objdl_Cliente.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objdl_Cliente.Eliminar(obj, out Mensaje);
        }
    }
}
