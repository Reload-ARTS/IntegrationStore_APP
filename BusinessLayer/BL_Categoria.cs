using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Categoria
    {
        private DL_Categoria objdl_Categoria = new DL_Categoria();

        public List<Categoria> Listar()
        {
            return objdl_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            //Validaciones
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objdl_Categoria.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Categoria obj, out string Mensaje)
        {
            //Validaciones
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion de la Categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objdl_Categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objdl_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
