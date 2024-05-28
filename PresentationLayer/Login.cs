using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;//Importar capa negocios
using EntityLayer;//Importar capa entidad

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            List<Usuario> Test = new BL_Usuario().Listar();

            //Obtenemos el usuario de quien se logea
            Usuario ousuario = new BL_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();

            //Condicion para verificar si existe el usuario
            if(ousuario != null)
            {
                //Nueva instancia
                Inicio form = new Inicio(ousuario);
                //Mostrar Formulario
                form.Show();
                //Ocultar Formulario
                this.Hide();
                //Union con la funcion frm_closing
                form.FormClosing += frm_closing;

            }
            else
            {
                //Mensaje de no encontrar usuario o que los datos ingresados sean incorrectos.
                MessageBox.Show("Usuario o contraseña incorrecto, intentalo de nuevo.","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            
        }

        //Volver al Login despues de cerrar la app "Inicio"
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            //Limpia los campos al volver al Login
            txtdocumento.Text = "";
            txtclave.Text = "";

            this.Show();
        }
    }
}
