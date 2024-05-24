using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_SisB;

namespace CapaVista_SisB
{
    public partial class MovimientosBancarios : Form
    {
         Controlador cn = new Controlador();
         Controlador con = new Controlador();
        string mov = "tbl_movimientosBancarios";
        public MovimientosBancarios()
        {
            InitializeComponent();
            CargarCuentasEnCombobox();
            actualizardatagridView();
            cmb_cuentaDebito.SelectedIndex = -1;
            cmb_cuentaCredito.SelectedIndex = -1;
            txt_cuentaDebito.Clear();
            txt_cuentaCredito.Clear();
            txt_valorTransferencia.Clear();
            txt_descripcionTransferencia.Clear();
            txt_estado.Clear();

            dgv_vistaTransacciones.Columns[0].HeaderText = "ID";
            dgv_vistaTransacciones.Columns[1].HeaderText = "Valor";
            dgv_vistaTransacciones.Columns[2].HeaderText = "Descripcion";
            dgv_vistaTransacciones.Columns[3].HeaderText = "Cuenta a debitar";
            dgv_vistaTransacciones.Columns[4].HeaderText = "Cuenta a acreditar";
            dgv_vistaTransacciones.Columns[5].HeaderText = "Estatus";
            dgv_vistaTransacciones.Columns[6].HeaderText = "Fecha de ingreso";

            cmb_cuentaDebito.SelectedIndexChanged += cmb_cuentaDebito_SelectedIndexChanged;
            cmb_cuentaCredito.SelectedIndexChanged += cmb_cuentaCredito_SelectedIndexChanged;
        }

        private void CargarCuentasEnCombobox()
        {
            DataTable dtCuentas = cn.ObtenerCuentas();
            cmb_cuentaDebito.DataSource = dtCuentas;
            cmb_cuentaDebito.DisplayMember = "cue_numero";
            cmb_cuentaDebito.ValueMember = "cue_id";

            cmb_cuentaCredito.DataSource = dtCuentas.Copy(); // Crear una copia para evitar conflictos con el mismo DataSource
            cmb_cuentaCredito.DisplayMember = "cue_numero";
            cmb_cuentaCredito.ValueMember = "cue_id";
        }
        public void actualizardatagridView()
        {
            DataTable dt = cn.llenarTbl(mov);
            dgv_vistaTransacciones.DataSource = dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Mov_bancarios_Load(object sender, EventArgs e)
        {


        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void btn_cancelarTransaccion_Click(object sender, EventArgs e)
        {




            DialogResult result = MessageBox.Show("¿Desea cancelar la transacción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cmb_cuentaDebito.SelectedIndex = -1;
                cmb_cuentaCredito.SelectedIndex = -1;
                txt_cuentaDebito.Clear();
                txt_cuentaCredito.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();
                txt_estado.Clear();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Transacción cancelada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se canceló la transaccion.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_rtrans_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txt_valorTransferencia.Text, out decimal valorTransferencia))
            {
                MessageBox.Show("El valor de la transferencia no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txt_cuentaDebito.Text, out int cuentaDebitoId) || !int.TryParse(txt_cuentaCredito.Text, out int cuentaCreditoId))
            {
                MessageBox.Show("Las cuentas seleccionadas no son válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal saldoCuentaDebito = cn.ObtenerSaldoCuenta(cuentaDebitoId);

            if (saldoCuentaDebito < valorTransferencia)
            {
                MessageBox.Show("Saldo insuficiente en la cuenta a debitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string estado = "1";
            DialogResult result = MessageBox.Show("¿Desea guardar la transacción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //OTTO ADRIAN LOPEZ VENTURA 0901-20-1069 

            if (result == DialogResult.Yes)
            {
                //LUIS ALBERTO FRANCO MORAN 0901-20-23979
                // Llamar al Controlador para insertar el movimiento en la base de datos
                cn.InsertarMovimiento(txt_valorTransferencia.Text, txt_descripcionTransferencia.Text, txt_cuentaDebito.Text, txt_cuentaCredito.Text, estado);

                // Actualizar el DataGridView con los datos actualizados
                actualizardatagridView();

                // Limpiar los TextBox
                cmb_cuentaDebito.SelectedIndex = -1;
                cmb_cuentaCredito.SelectedIndex = -1;
                txt_cuentaDebito.Clear();
                txt_cuentaCredito.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();
                txt_estado.Clear();


                // Mostrar un mensaje de éxito
                MessageBox.Show("Movimiento realizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //LUIS ALBERTO FRANCO MORAN 0901-20-23979
                // Limpiar los TextBox si el usuario elige "No"
                cmb_cuentaDebito.SelectedIndex = -1;
                cmb_cuentaCredito.SelectedIndex = -1;
                txt_cuentaDebito.Clear();
                txt_cuentaCredito.Clear();
                txt_valorTransferencia.Clear();
                txt_descripcionTransferencia.Clear();
                txt_estado.Clear();

                // Mostrar un mensaje informativo
                MessageBox.Show("No se guardó el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);//OTTO ADRIAN LOPEZ VENTURA 0901-20-1069 
            }
        }

        private void cmb_cuentaDebito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cuentaDebito.SelectedValue != null)
            {
                txt_cuentaDebito.Text = cmb_cuentaDebito.SelectedValue.ToString();
            }
        }

        private void cmb_cuentaCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cuentaCredito.SelectedValue != null)
            {
                txt_cuentaCredito.Text = cmb_cuentaCredito.SelectedValue.ToString();
            }
        }
    }
}
