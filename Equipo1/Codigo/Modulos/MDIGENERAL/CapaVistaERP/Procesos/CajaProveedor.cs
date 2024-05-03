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
            DataTable dt = cn.filtrardatos(tabla1, "nitprov_facxpag", filtro);
            dgv_pagoproveedor.DataSource = dt;
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
           // dgv_pagoproveedor.DataBindingComplete += dgv_pagoproveedor_DataBindingComplete;

            filtrodata();
        }

        double sumaTotal = 0;
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Verificar si el contenido del TextBox es un número válido
            if (double.TryParse(txt_factotal.Text, out double valor))
            {
                // Sumar el valor al total acumulado
                sumaTotal += valor;

                // Mostrar la suma total en el otro TextBox
                txt_totalapagar.Text = sumaTotal.ToString();

                txtNoFactura.Text = "";
                txt_FechaV.Text = "";
                txt_facSub.Text = "";
                txt_factotal.Text = "";
                
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_pagoproveedor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_pagoproveedor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_pagoproveedor_SelectionChanged(object sender, EventArgs e)
        {

            // Verificar si hay alguna fila seleccionada
            if (dgv_pagoproveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_pagoproveedor.SelectedRows[0];

                // Obtener los valores de las celdas y asignarlos a los TextBoxes
                txtNoFactura.Text = filaSeleccionada.Cells["NoFactura"].Value.ToString();
                    txt_FechaV.Text = filaSeleccionada.Cells["fechavenc_facxpag"].Value.ToString();
                    txt_facSub.Text = filaSeleccionada.Cells["subtotal_facxpag"].Value.ToString();
                    txt_factotal.Text = filaSeleccionada.Cells["totalfac_facxpag"].Value.ToString();
               
            }
        }


        private double totalFacturasAcumulado = 0;
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verificar si el contenido del TextBox es un número válido
            if (double.TryParse(txt_factotal.Text, out double montoFactura))
            {
                // Restar el monto de la factura del total acumulado de facturas
                totalFacturasAcumulado -= montoFactura;

                // Restar el monto de la factura de la suma total
                sumaTotal -= montoFactura;

                // Asegurarse de que el total acumulado no sea menor que cero
                if (totalFacturasAcumulado < 0)
                {
                    totalFacturasAcumulado = 0;
                }

                // Asegurarse de que la suma total no sea menor que cero
                if (sumaTotal < 0)
                {
                    sumaTotal = 0;
                }

                // Mostrar el nuevo total acumulado de facturas en el TextBox correspondiente
                txt_totalapagar.Text = sumaTotal.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto de factura válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
