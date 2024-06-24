using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Proveedor
    {
        private DL_Proveedor objdl_Proveedor = new DL_Proveedor();

        public List<Proveedor> Listar()
        {
            return objdl_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            //Validaciones
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objdl_Proveedor.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            //Validaciones
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario el nombre completo del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objdl_Proveedor.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objdl_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
