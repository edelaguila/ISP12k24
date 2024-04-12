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

namespace CapaVistaERP.Mantenimientos
{
    public partial class frmMantenimientoCuentaBancaria : Form
    {
        Controlador cn = new Controlador();
        public frmMantenimientoCuentaBancaria()
        {
            // colocar numero correspondiente
            InitializeComponent();
            this.navegador1.config("tbl_cuentabancaria", this, "8030");
            LlenarComboBanco();
        }

        public void LlenarComboBanco()
        {
            List<string> concepto = cn.llenarCombo("nombre_banco", "tbl_banco");
            cb_banco.Items.Clear();
            cb_banco.Items.AddRange(concepto.ToArray());
        }

        public void BuscarBanco()
        {
            string tabla = "tbl_banco";

            string columna = "nombre_banco";
            // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_banco.SelectedItem != null) ? cb_banco.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_banco.Text = row["id_banco"].ToString();


            }
            else
            {

            }
        }


        private void cb_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_banco.Clear();

            BuscarBanco();
            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            //string opcionSeleccionada = cb_banco.SelectedItem.ToString();
            //txt_banco.Text = opcionSeleccionada;
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_tipoCuenta.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_tipo.SelectedItem.ToString();
            txt_tipoCuenta.Text = opcionSeleccionada;
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_estado.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_estado.SelectedItem.ToString();
            txt_estado.Text = opcionSeleccionada;
        }

        private void cb_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_moneda.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_moneda.SelectedItem.ToString();
            txt_moneda.Text = opcionSeleccionada;
        }
    }
}
