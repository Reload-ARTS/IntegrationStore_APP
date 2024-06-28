using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Modales
{
    public partial class MD_Acercade : Form
    {
        public MD_Acercade()
        {
            InitializeComponent();
            richTextBoxAcercaDe.Font = new Font("Arial", 12);
            richTextBoxAcercaDe.Text = "Este proyecto ha sido desarrollado como parte de la asignatura 'Integración de Competencias I' en la carrera de Analista Programador, bajo la guía del profesor Alonso Berrios Cortes.\n\n" +
                               "Descripción del Proyecto\n\n" +
                               "El sistema de compra, venta y control de inventario está diseñado para una tienda de informática que ofrece una amplia gama de productos, desde componentes de hardware hasta accesorios tecnológicos. Nuestro objetivo es facilitar la gestión eficiente de inventarios, optimizar las transacciones de compra y venta, y proporcionar informes precisos sobre el estado de los productos y las finanzas de la tienda.\n\n" +
                               "Funcionalidades Principales\n\n" +
                               "Gestión de Inventario: Permite añadir, actualizar y eliminar productos, así como gestionar sus categorías, precios y stock.\n" +
                               "Registro de Compras: Facilita la compra de productos a proveedores, actualizando automáticamente el inventario y generando documentos de compra.\n" +
                               "Registro de Ventas: Gestiona la venta de productos a clientes, actualizando el inventario y generando recibos de venta.\n" +
                               "Informes: Genera informes detallados sobre el estado del inventario, las compras y las ventas, ayudando en la toma de decisiones.\n\n" +
                               "Equipo de Desarrollo\n\n" +
                               "Cristian Salgado\n" +
                               "Jean Huachaca\n" +
                               "Antonio Toro\n\n" +
                               "Cada uno de los miembros del equipo ha contribuido significativamente en diferentes aspectos del proyecto, desde el diseño de la base de datos hasta la implementación de la interfaz de usuario y la lógica de negocio.\n\n" +
                               "Agradecimientos\n\n" +
                               "Queremos expresar nuestro agradecimiento a los siguientes grupos y comunidades por su apoyo y recursos:\n\n" +
                               "Programadores Chile (grupo de Facebook)\n" +
                               "Grupo Discord de midudev\n" +
                               "MoureDev\n\n" +
                               "Su valiosa orientación, recursos y apoyo han sido fundamentales en el desarrollo de este proyecto.";
        }

    }
}
