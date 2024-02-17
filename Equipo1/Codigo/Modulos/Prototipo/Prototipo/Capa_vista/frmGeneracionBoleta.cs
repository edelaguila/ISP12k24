using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;

namespace Vista_PrototipoMenu
{
    public partial class frmGeneracionBoleta : Form
    {
        Controlador cn = new Controlador();
        public frmGeneracionBoleta()
        {
            InitializeComponent();
            LlenarComboTipoPasaporte();
            LlenarComboDPI();
            cb_pasaporte.SelectedIndexChanged += CbPasaporte_SelectedIndexChanged;

        }

        public void LlenarComboTipoPasaporte()
        {
            List<string> concepto = cn.llenarCombo("id_prepasaporte", "tbl_preciopasaporte");
            cb_pasaporte.Items.Clear();
            cb_pasaporte.Items.AddRange(concepto.ToArray());

        }

        public void LlenarComboDPI()
        {
            List<string> concepto = cn.llenarCombo("renap_dpi", "tbl_renap");
            cb_dpi.Items.Clear();
            cb_dpi.Items.AddRange(concepto.ToArray());

        }

        public void BuscarPreciosPasaporte()
        {
            string tabla = "tbl_preciopasaporte";

            string columna = "id_prepasaporte";
            string dato = cb_pasaporte.SelectedItem.ToString();
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");   
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_pasaporteSeleccionado.Text = row["prepasaporte_nombre"].ToString();
                txt_tasaPromedio.Text = row["prepasaporte_tasa"].ToString();
                txt_precioDolar.Text = row["prepasaporte_dolar"].ToString();
                txt_precioQuetzal.Text = row["prepasaporte_quetzales"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro el dato");
            }
        }

        public void BuscarDPI()
        {
            string tabla = "tbl_renap";

            string columna = "renap_dpi";
            string dato = cb_dpi.SelectedItem.ToString();
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_identificadorDPI.Text = row["id_renap"].ToString();
                txt_nombre.Text = row["renap_nombre"].ToString();
                txt_genero.Text = row["renap_genero"].ToString();
                txt_edad.Text = row["renap_edad"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro el dato");
            }
        }



        private void CbPasaporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llama a la función de búsqueda al cambiar la selección en el ComboBox
            BuscarPreciosPasaporte();
        }

        private void btn_BusquedaDPI_Click(object sender, EventArgs e)
        {
            BuscarDPI();
        }
    }
}
