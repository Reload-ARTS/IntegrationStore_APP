﻿using EntityLayer;
using PresentationLayer.Modales;
using PresentationLayer.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {

            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";
            txtidproveedor.Text = "0";


        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Proveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.Documento;
                    txtnombreproveedor.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Producto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtnombreproducto.Text = modal._Producto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtdocproveedor.Select();
                }

            }
        }
    }
}
