using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVistaERP.Procesos
{
    public partial class MovimientoProveedores : Form
    {
        
        private Controlador cn;
        string tabla1 = "tbl_proveedor";
        public MovimientoProveedores(string idprov, string nombreprov, string nitprov)
        {
            InitializeComponent();
            cn = new Controlador();
            tabla();
            txt_Idprov.Text = idprov;
            txt_nombreprov.Text = nombreprov;
            txt_nitprov.Text = nitprov;
            
        }
        public void tabla()
        {
            DataTable dt = cn.llenarTablas(tabla1);
            dgv_proveedores.DataSource = dt;
        }

        private void btn_pagoproveedor_Click(object sender, EventArgs e)
        {
            CajaProveedor CajaProveedor = new CajaProveedor(this);
            CajaProveedor.Show();

        }

        private void dgv_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
