﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntityLayer;//Importar capa entidad

namespace PresentationLayer
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Mostrar el usuario actual 
            lblusuario.Text = usuarioActual.NombreCompleto;
        }
    }
}
