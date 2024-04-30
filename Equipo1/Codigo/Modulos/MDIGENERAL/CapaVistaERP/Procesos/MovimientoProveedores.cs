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
    //Andrea Corado 0901-20-2841
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

        public void BuscarProv()
        {
            string idprove = txt_Idprov.Text;
            string nombreprov = txt_nombreprov.Text;
            string nitprove = txt_nitprov.Text;


            DataTable dt = cn.BuscarProv(tabla1, "id_prov", idprove, "nombre_prov", nombreprov, "nit_prov", nitprove);
            dgv_proveedores.DataSource = dt;

            txt_Idprov.Text = "";
            txt_nombreprov.Text = "";
            txt_nitprov.Text = "";
        }

        private void btn_pagoproveedor_Click(object sender, EventArgs e)
        {
            string idprove = txt_Idprov.Text;
            string nombreprov = txt_nombreprov.Text;
            string nitprove = txt_nitprov.Text;

            CajaProveedor CajaProveedor = new CajaProveedor(idprove,nombreprov,nitprove);
            CajaProveedor.txt_Idprov.Text = idprove.ToString();
            CajaProveedor.txt_nombre.Text = nombreprov.ToString();
            CajaProveedor.txt_nitprov.Text = nitprove.ToString();
            CajaProveedor.Show();
        }

        private void dgv_proveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_proveedores.SelectedRows.Count > 0)
            {
                string idProv = dgv_proveedores.SelectedRows[0].Cells["id_prov"].Value.ToString();
                txt_Idprov.Text = idProv;
                string nomProv = dgv_proveedores.SelectedRows[0].Cells["nombre_prov"].Value.ToString();
                txt_nombreprov.Text = nomProv;
                string NitProv = dgv_proveedores.SelectedRows[0].Cells["nit_prov"].Value.ToString();
                txt_nitprov.Text = NitProv;

            }
        }
        private void dgv_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProv();
        }

        private void btn_refrescartabla_Click(object sender, EventArgs e)
        {
            tabla();
        }
    }
}
