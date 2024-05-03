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
namespace CapaVistaERP.Procesos
{//carlos enrique guzman cabrera
    public partial class AutorizacionOrdenDeCompra : Form
    {
        Controlador cn = new Controlador();
        public AutorizacionOrdenDeCompra()
        {
            InitializeComponent();
            LlenarComboCuentaBancaria();
            LlenarComboOrdenCompra();
            
        }

        public void LlenarComboOrdenCompra()
        {
            List<string> concepto = cn.llenarCombo("id_OrdComp", "tbl_ordenescompra");
            cb_numeroOrden.Items.Clear();
            cb_numeroOrden.Items.AddRange(concepto.ToArray());
        }

        public void BuscarDetalleOrden()
        {
            string tabla = "tbl_ordenescompra";

            string columna = "id_OrdComp";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_numeroOrden.SelectedItem != null) ? cb_numeroOrden.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                // MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_departamentoSolicitante.Text = row["deptoSolicitante_OrdComp"].ToString();
                txt_entregarPersona.Text = row["entregar_a_OrdComp"].ToString();
                txt_fechaSolicitud.Text = row["fechaSolicitid_OrdComp"].ToString();
                txt_fechaEntrega.Text = row["fechaEntrega_OrdComp"].ToString();
                txt_subTotal.Text = row["subTotal_OrdComp"].ToString();
                txt_iva.Text = row["iva_OrdComp"].ToString();
                txt_totalOrden.Text = row["totalOrden_OrdComp"].ToString();

            }
            else
            {

            }
        }

        public void LlenarComboCuentaBancaria()
        {
            List<string> concepto = cn.llenarCombo("nombre_empresa", "tbl_cuentabancaria");
            cb_cuenta.Items.Clear();
            cb_cuenta.Items.AddRange(concepto.ToArray());
        }

        public void BuscarDetalleCuentas()
        {
            string tabla = "tbl_cuentabancaria";

            string columna = "nombre_empresa";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_cuenta.SelectedItem != null) ? cb_cuenta.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

               // MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_IDCUENTA.Text = row["id_cuentaBancaria"].ToString();
                txt_estadoCuenta.Text = row["estado_cuenta"].ToString();
                txt_NoCuenta.Text = row["numero_cuenta"].ToString();
                txt_saldoDisponible.Text = row["saldoDisponible"].ToString();
            }
            else
            {

            }
        }

        public void GuardarDatos()
        {
            string tabla = "tbl_autorizacionordenescompra";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            //valores.Add("estadoOrden", int.Parse(txt_IDmovimiento.Text));
            //valores.Add("conceptoDeAutorizacion", dtp_fecha.Value);
            valores.Add("estadoOrden", cb_estado.SelectedItem.ToString());
            valores.Add("conceptoDeAutorizacion", txt_Descripcion.Text);
            valores.Add("fechaAutorizacion", dtp_fechaAutorizacion.Value);
            valores.Add("subTotal", double.Parse(txt_subTotal.Text));
            valores.Add("iva", double.Parse(txt_iva.Text));
            valores.Add("totalOrden", double.Parse(txt_totalOrden.Text));
            valores.Add("cuentaAsociada", int.Parse(txt_IDCUENTA.Text));
            valores.Add("tbl_OrdenesCompra_id_OrdComp", cb_numeroOrden.SelectedItem);

            cn.GuardarDatos(tabla, valores);

            //MessageBox.Show("Datos guardados");
        }

        private void AutorizacionOrdenDeCompra_Load(object sender, EventArgs e)
        {
            espera.Visible = true;
        }

        private void cb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleCuentas();
        }
        private void cb_numeroOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleOrden();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_fechaEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txt_fechaSolicitud_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            MessageBox.Show("Datos Guardados");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("Se limpiaran todas las casillas. ¿Desea limpiar?", "Confirmación", MessageBoxButtons.YesNo);

            // Si el usuario elige "Sí", cerrar la ventana; de lo contrario, mantenerla abierta.
            if (result == DialogResult.Yes)
            {
                txt_departamentoSolicitante.Clear();
                txt_entregarPersona.Clear();
                txt_fechaSolicitud.Clear();
                txt_fechaEntrega.Clear();
                txt_subTotal.Clear();
                txt_iva.Clear();
                txt_totalOrden.Clear();
                cb_estado.SelectedIndex = -1;
                txt_totalOrden.Clear();
                txt_Descripcion.Clear();
                txt_estadoCuenta.Clear();
                txt_saldoDisponible.Clear();
                txt_NoCuenta.Clear();
                cb_cuenta.SelectedIndex = -1;
                cb_numeroOrden.SelectedIndex = -1;

                btn_guardar.Enabled = false;
                positivo.Visible = false;
                espera.Visible = true;
                lb_respuesta.Text = "Esperando...";

            } else if (result == DialogResult.No) {
                MessageBox.Show("no se limpiaron las casillas");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void positivo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
         
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrEmpty(txt_totalOrden.Text) || string.IsNullOrEmpty(txt_saldoDisponible.Text))
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Obtener los valores de los TextBox como double
                double totalOrden = double.Parse(txt_totalOrden.Text);
                double saldoDisponible = double.Parse(txt_saldoDisponible.Text);

                if (totalOrden < saldoDisponible)
                {
                    // Si totalOrden < saldoDisponible
                    btn_guardar.Enabled = true;
                    positivo.Visible = true;
                    negativo.Visible = false;
                    espera.Visible = false;
                    lb_respuesta.Text = "El saldo cubre\nla orden";
                }
                else if (totalOrden > saldoDisponible)
                {
                    btn_guardar.Enabled = true;
                    positivo.Visible = false;
                    negativo.Visible = true;
                    espera.Visible = false;
                    lb_respuesta.Text = "El saldo no cubre\nla orden";
                }
            }


        }

        private void espera_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

