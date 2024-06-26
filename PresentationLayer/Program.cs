using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CL");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Donde empieza la APP generalmente el Login
            Application.Run(new Inicio());
        }
    }
}
