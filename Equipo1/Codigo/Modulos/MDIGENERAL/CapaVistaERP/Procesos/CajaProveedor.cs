using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            txt_nit.TextChanged += txt_nombre_TextChanged;
            
        }

        public void tabla()
        {
            DataTable dt = cn.llenarTablas(tabla1);
            dgv_pagoproveedor.DataSource = dt;
        }


        /*public void filtrodata()
        {
            string filtro = txt_nit.Text;
            string data = "0";
            DataTable dt = cn.filtrardatosp(tabla1, "nitprov_facxpag", filtro, "estado_facxpag", data);
            dgv_pagoproveedor.DataSource = dt;
        }*/

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

        public void Combodefacturas()
        {
            try
            {
                List<string> producto = cn.ComboFillfactura("NoFactura", "tbl_facturaxpagar", "nitprov_facxpag", txt_nit.Text, "estado_facxpag");
                cb_nofact.Items.Clear();
                cb_nofact.Items.AddRange(producto.ToArray());

                // Suscribir el evento SelectedIndexChanged del ComboBox
                cb_nofact.SelectedIndexChanged += (sender, e) => {
                    // Obtener el número de factura seleccionado
                    string noFacturaSeleccionada = cb_nofact.SelectedItem.ToString();
                    // Obtener los datos de la factura seleccionada y llenar los campos
                    LlenarCamposFactura(noFacturaSeleccionada);
                };

            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        }

        public void LlenarCamposFactura(string noFactura)
        {
            
            try
            {
                (DateTime fechaVencimiento, decimal total) = cn.ObtenerFechaVYTotal(noFactura);
                // Llenar los campos de texto con los datos obtenidos
                txt_FechaV.Text = fechaVencimiento.ToString(); // Ajusta el formato según sea necesario
                txt_factotal.Text = total.ToString(); // Ajusta el formato según sea necesario
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al llenar los campos de la factura: " + e.Message);
            }
        }

        private void cmb_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_bancos.Text = cmb_banco.SelectedItem.ToString();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            //ActualizarComboBoxFacturas(txt_nit.Text);
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
            //filtrodata();
            Combodefacturas();
        }

        double sumaTotal = 0;
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número de factura seleccionado
                string noFacturaSeleccionada = cb_nofact.SelectedItem.ToString();

                // Obtener los datos de la factura seleccionada
                (DateTime fechaVencimiento, decimal total) = cn.ObtenerFechaVYTotal(noFacturaSeleccionada);

                // Agregar una nueva fila al DataGridView
                dgv_pagoproveedor.Rows.Add(noFacturaSeleccionada, fechaVencimiento.ToString(), total.ToString());

                if (double.TryParse(txt_factotal.Text, out double valor))
                {
                    // Sumar el valor al total acumulado
                    sumaTotal += valor;

                    // Mostrar la suma total en el otro TextBox
                    txt_totalapagar.Text = sumaTotal.ToString();

                    //txtNoFactura.Text = "";
                    txt_FechaV.Text = "";
                    txt_factotal.Text = "";

                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la factura al DataGridView: " + ex.Message);
            }


            /* Verificar si el contenido del TextBox es un número válido
            if (double.TryParse(txt_factotal.Text, out double valor))
            {
                // Sumar el valor al total acumulado
                sumaTotal += valor;

                // Mostrar la suma total en el otro TextBox
                txt_totalapagar.Text = sumaTotal.ToString();

                //txtNoFactura.Text = "";
                txt_FechaV.Text = "";
                txt_facSub.Text = "";
                txt_factotal.Text = "";
                
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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

        }


        private double totalFacturasAcumulado = 0;
        private void ActualizarSubtotal()
        {
            double subtotal = 0.0;
            foreach (DataGridViewRow row in dgv_pagoproveedor.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Totalfacturas"].Value);
            }
            txt_totalapagar.Text = subtotal.ToString();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_pagoproveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow DGVfila = dgv_pagoproveedor.SelectedRows[0];
                dgv_pagoproveedor.Rows.Remove(DGVfila);
                ActualizarSubtotal();
            }
            else
            {
                MessageBox.Show("Seleccione una fila valida para eliminar");
            }

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            /*try
            {
                string idp = txt_idprov.Text;
                string fechamov = dt_fechaabono.Value.ToString("yyyy/MM/dd");
                string totalmov = txt_totalapagar.Text;
                string nofact = txtNoFactura.Text;
                string banmov = txt_bancos.Text;
                string tipomov = txt_tipomovpro.Text;
                string numov = txt_numero.Text;
                string conceptomov = txt_concepto.Text;

                cn.Guardarmovpro(idp, fechamov, totalmov, nofact, banmov, tipomov, numov, conceptomov);

                int num;
                int.TryParse(nofact, out num);
                string dato = "0";

                cn.Actualizap(tabla1, "estado_facxpag", dato, "NoFactura", num);
                MessageBox.Show("Pago Realizado con Éxito");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
        private void LimpiarCampos()
        {
            txt_idprov.Clear();
            txt_nombreprov.Clear();
            txt_nitprov.Clear();
            txt_nit.Clear();
            //txtNoFactura.Clear();
            txt_totalapagar.Clear();
            txt_bancos.Clear();
            txt_tipomovpro.Clear();
            txt_numero.Clear();
            dt_fechaabono.Value = DateTime.Now; // Restablece la fecha actual
            txt_concepto.Clear();
            sumaTotal = 0;
            totalFacturasAcumulado = 0;
        }

        private void txt_tipomovpro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_tipotransa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tipomovpro.Text = cb_tipotransa.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
