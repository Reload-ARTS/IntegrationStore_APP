using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Compra
    {
        public List<Detalle_Compra> oDetalleCompra;

        //Datos de nuestra tabla en BDD
        public int IdCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        //creamos como lista ya que pueden existir varias compras
        public List<Detalle_Compra> oDetalle_Compra { get; set; }
        public string FechaRegistro { get; set; }
    }
}
