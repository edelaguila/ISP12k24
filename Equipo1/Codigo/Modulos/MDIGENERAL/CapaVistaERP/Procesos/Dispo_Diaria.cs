using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

using CapaControladorERP;
namespace CapaVistaERP.Procesos
{
    public partial class Dispo_Diaria : Form
    {
        Controlador cn = new Controlador();
        public Dispo_Diaria()
        {
            InitializeComponent();
            LlenarComboCuentaBancaria();
            LlenarComboCuentaBancaria2();
            actualizardatagriew();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string emp = "tbl_movimientodebancos";
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenartablabitacoraMB(emp);
            dataGridView1.DataSource = dt;

        }
        public void LlenarComboCuentaBancaria()
        {
            List<string> concepto = cn.llenarCombo("nombre_empresa", "tbl_cuentabancaria");
            cb_cuenta.Items.Clear();
            cb_cuenta.Items.AddRange(concepto.ToArray());
        }
        public void LlenarComboCuentaBancaria2()
        {
            List<string> concepto = cn.llenarCombo("nombre_banco", "tbl_banco");
            txtIdBanco.Items.Clear();
            txtIdBanco.Items.AddRange(concepto.ToArray());
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
                txt_IDCUENTAB.Text = row["id_cuentaBancaria"].ToString();
                txt_nombreCuenta.Text = row["nombre_empresa"].ToString();
                txt_noCuenta.Text = row["numero_cuenta"].ToString();
                txt_tipoCuenta.Text = row["tipo_cuenta"].ToString();
                txt_estadoCuenta.Text = row["estado_cuenta"].ToString();
                textsaldoactual.Text = row["saldoDisponible"].ToString();
            }
            else
            {

            }
        }

        private void cb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_cuenta.SelectedItem != null)
            {
                // Si se selecciona algo en el ComboBox, habilita el Label y el botón
                label4.Visible = true;
                botton3.Enabled = true;
                botton3.Visible = true;
                Calcular.Visible = true;
                Registrar.Visible = true;
                Cancelar.Visible = true;
            }
            else
            {
                // Si no se selecciona nada en el ComboBox, deshabilita el Label y el botón
                label4.Visible = false;
                botton3.Enabled = false;
                botton3.Visible = false;
                Calcular.Visible = false;
                Registrar.Visible = false;
                Cancelar.Visible = false;
            }

            BuscarDetalleCuentas();
        }
        public void BuscarDetalleBanco()
        {
            // Obtener el valor del ID del banco desde el TextBox correspondiente

            string tabla = "tbl_banco";

            string columna = "nombre_banco";

            string dato = (txtIdBanco.SelectedItem != null) ? txtIdBanco.SelectedItem.ToString() : string.Empty;

            // Realizar la búsqueda en la base de datos
            DataTable dt = cn.Buscar(tabla, columna, dato);

            // Verificar si se encontraron resultados
            if (dt.Rows.Count > 0)
            {
                // Mostrar los detalles del banco encontrados en los TextBox correspondientes
                txt_IDBanco.Text = dt.Rows[0]["id_banco"].ToString();
                txtNombreBanco.Text = dt.Rows[0]["nombre_banco"].ToString();

                txtEstadoBanco.Text = dt.Rows[0]["estado_banco"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }

        private void botton3_Click(object sender, EventArgs e)
        {
            BuscarDetalleBanco();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal totalFondosRetiro = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["tipo_movimientoBanco"].Value != null && row.Cells["monto_movimientoBanco"].Value != null)
                {
                    // Verificar si el valor de la columna tipo_movimientoBanco es igual a 2
                    if (row.Cells["tipo_movimientoBanco"].Value.ToString() == "2")
                    {
                        // Obtener el valor de la celda monto_movimientoBanco y convertirlo a decimal
                        decimal monto;
                        if (decimal.TryParse(row.Cells["monto_movimientoBanco"].Value.ToString(), out monto))
                        {
                            // Sumar el monto al total
                            totalFondosRetiro += monto;
                        }
                    }
                }
            }

            // Asignar el total al TextBox txtFondoRetiro
            txtFondoRetiro.Text = totalFondosRetiro.ToString();

            // Restar el valor de txtFondoRetiro al valor de txtSaldoActual y mostrar el resultado en txtSaldoDisponible
            decimal saldoActual, fondoRetiro;
            if (decimal.TryParse(textsaldoactual.Text, out saldoActual) && decimal.TryParse(txtFondoRetiro.Text, out fondoRetiro))
            {
                decimal saldoDisponible = saldoActual - fondoRetiro;
                txtSaldoDisponible.Text = saldoDisponible.ToString();
            }
            else
            {
                // Manejar la situación en la que los valores de los TextBox no sean números válidos
                MessageBox.Show("Los valores de Saldo Actual y Fondo de Retiro deben ser números válidos.");
            }
        }
        public void GuardarDatos()
            {
                string tabla = "tbl_disponibilidaddiaria";
                Dictionary<string, object> valores = new Dictionary<string, object>();

                valores.Add("id_cuentaDisponibilidad", int.Parse(txt_IDCUENTAB.Text));
                valores.Add("id_bancoActual", int.Parse(txt_IDBanco.Text));
                valores.Add("saldo_disponible", double.Parse(txtSaldoDisponible.Text));
                valores.Add("saldo_consumido", double.Parse(txtFondoRetiro.Text));
                valores.Add("saldo_actual", double.Parse(textsaldoactual.Text));
                valores.Add("fecha_DisponibilidadDiaria", dtp_fecha.Value);

                cn.GuardarDatos(tabla, valores);

                MessageBox.Show("Datos guardados");
            }

        private void Registrar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
        private void LimpiarCampos()
        {
            txt_IDCUENTAB.Clear();
            txt_nombreCuenta.Clear();
            txt_noCuenta.Clear();
            txt_tipoCuenta.Clear();
            txt_estadoCuenta.Clear();
            textsaldoactual.Clear();
            txt_IDBanco.Clear();
            txtNombreBanco.Clear();
            txtEstadoBanco.Clear();
            txtFondoRetiro.Clear();
            txtSaldoDisponible.Clear();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Se han cancelado los registros.", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    
}



