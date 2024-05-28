using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //Se encarga de enviar a las demas clases la cadena de conexion 
    //que tenemos almacenada en nuestro archivo app.config
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}
