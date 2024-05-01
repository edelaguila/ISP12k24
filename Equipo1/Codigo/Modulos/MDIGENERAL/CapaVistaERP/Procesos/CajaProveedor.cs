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
    public partial class CajaProveedor : Form
    {
        private Controlador cn;
        string tabla1 = "tbl_facturaxpagar";
        
        public CajaProveedor(string idprove, string nombreprov, string nitprove)
        {
            InitializeComponent();
            cn = new Controlador();
            Combo();
            Combo2();
        }

        public void tabla()
        {
            DataTable dt = cn.llenarTablas(tabla1);
            dgv_pagoproveedor.DataSource = dt;
        }


        public void filtrodata()
        {
            string filtro = txt_nit.Text;
            DataTable dt = cn.filtrardatos(tabla1,"nitprov_facxpag", filtro);
            dgv_pagoproveedor.DataSource = dt;
        }


        private void dgv_pagoproveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_pagoproveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_pagoproveedor.SelectedRows[0];

                string total = filaSeleccionada.Cells["totalfac_facxpag"].Value.ToString();
                txt_totalapagar.Text = total;
            }

        }

        public void Combo()
        {
            try
            {
                List<string> producto = cn.ComboFill("nombre_banco", "tbl_banco");
                cmb_banco.Items.Clear();
                cmb_banco.Items.AddRange(producto.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        }

        public void Combo2()
        {
            try
            {
                List<string> producto = cn.ComboFill("nombre_transprov", "tbl_transprov");
                cb_tipotransa.Items.Clear();
                cb_tipotransa.Items.AddRange(producto.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        }

        private void cmb_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_bancos.Text = cmb_banco.SelectedItem.ToString();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            MovimientoProveedores proveedor = new MovimientoProveedores(this);
            proveedor.Show();
        }


        public void datosProv (string idprov,string nombreprov,string nitprov)
        {
            txt_idprov.Text = idprov;
            txt_nombreprov.Text = nombreprov;
            txt_nitprov.Text = nitprov;
            txt_nit.Text= nitprov;
        }

        private void btn_buscarFactura_Click(object sender, EventArgs e)
        {
            filtrodata();
        }
    }
}
