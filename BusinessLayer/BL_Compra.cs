using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Compra
    {
        private DL_Compra objdl_compra = new DL_Compra();

        public int ObtenerCorrelativo()
        {
            return objdl_compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra obj,DataTable DetalleCompra, out string Mensaje)
        {

            return objdl_compra.Registrar(obj,DetalleCompra, out Mensaje);
        }
    }
}
