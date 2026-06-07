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
            richTextBoxAcercaDe.Text = "Integration Store\n\n" +
                "Descripción del Proyecto\n\n" +
                
                "Integration Store es un sistema de gestión de inventario, compras y ventas desarrollado como proyecto académico para la carrera de Analista Programador. " +
                "La aplicación está orientada a pequeñas y medianas empresas que requieren administrar productos, proveedores, clientes y transacciones comerciales desde una única plataforma.\n\n" +

                "El objetivo principal del sistema es optimizar la gestión operativa del negocio, manteniendo un control actualizado del inventario y proporcionando herramientas para el seguimiento de compras, ventas y generación de reportes.\n\n" +

                "Funcionalidades Principales\n\n" +

                "Gestión de Usuarios y Roles: Administración de usuarios con control de acceso según perfil.\n" +
                "Gestión de Inventario: Creación, edición y control de productos, categorías, precios y stock.\n" +
                "Gestión de Clientes y Proveedores: Registro y administración de entidades comerciales.\n" +
                "Registro de Compras: Actualización automática del inventario mediante el ingreso de compras a proveedores.\n" +
                "Registro de Ventas: Procesamiento de ventas con actualización automática de stock.\n" +
                "Reportes: Consulta y análisis de compras y ventas mediante filtros específicos.\n" +
                "Exportación de Datos: Generación de reportes en formato Excel.\n" +
                "Documentos PDF: Emisión de comprobantes de compra y venta en formato PDF.\n\n" +

                "Tecnologías Utilizadas\n\n" +

                "• C#\n" +
                "• Windows Forms\n" +
                "• SQL Server\n" +
                "• Arquitectura Multicapa (Presentation, Business, Data y Entity Layer)\n" +
                "• Exportación Excel\n" +
                "• Generación de PDF\n\n" +

                "Desarrollador\n\n" +

                "Antonio Toro Sagredo\n" +
                "Analista Programador\n\n" +

                "Proyecto desarrollado durante el año 2024 como parte del proceso formativo de la carrera de Analista Programador.\n\n" +

                "Agradecimientos\n\n" +

                "A las comunidades de desarrollo y aprendizaje que sirvieron como apoyo durante el desarrollo del proyecto, especialmente Programadores Chile, Midudev y MoureDev, cuyos recursos y contenido contribuyeron al aprendizaje de diversas tecnologías utilizadas en esta aplicación.";
        }

    }
}
