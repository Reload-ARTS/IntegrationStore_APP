using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BL_Reporte
    {
        private DL_Reporte objcd_reporte = new DL_Reporte();

        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objcd_reporte.Compra(fechainicio, fechafin, idproveedor);
        }


        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            return objcd_reporte.Venta(fechainicio, fechafin);
        }
    }
}
