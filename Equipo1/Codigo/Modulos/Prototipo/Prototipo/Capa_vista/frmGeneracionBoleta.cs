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
            List<string> concepto = cn.llenarCombo("Pk_id_prepasaporte", "tbl_preciopasaporte");
            cb_pasaporte.Items.Clear();
            cb_pasaporte.Items.AddRange(concepto.ToArray());

        }

        public void LlenarComboDPI()
        {
            List<string> concepto = cn.llenarCombo("Pk_num_dpi", "tbl_renap");
            cb_dpi.Items.Clear();
            cb_dpi.Items.AddRange(concepto.ToArray());

        }

        public void BuscarPreciosPasaporte()
        {
            string tabla = "tbl_preciopasaporte";

            string columna = "Pk_id_prepasaporte";
           // string dato = cb_pasaporte.SelectedItem.ToString();
            string dato = (cb_pasaporte.SelectedItem != null) ? cb_pasaporte.SelectedItem.ToString() : string.Empty;

            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");   
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_IDpasaport.Text = row["Pk_id_prepasaporte"].ToString();
                txt_pasaporteSeleccionado.Text = row["prepasaporte_nombre"].ToString();
                txt_tasaPromedio.Text = row["prepasaporte_tasa"].ToString();
                txt_precioDolar.Text = row["prepasaporte_dolar"].ToString();
                txt_precioQuetzal.Text = row["prepasaporte_quetzales"].ToString();

            }
            else
            {
                
            }
        }

        public void BuscarDPI()
        {
            string tabla = "tbl_renap";

            string columna = "Pk_num_dpi";
            string dato = cb_dpi.SelectedItem.ToString();
            DataTable dt = cn.Buscar(tabla, columna, dato);

            if (dt.Rows.Count > 0)
            {

                MessageBox.Show("Datos Encontrados");
                DataRow row = dt.Rows[0]; // Tomamos la primera fila (si hay resultados)

                // Llenamos los controles con los valores del resultado
                txt_identificadorDPI.Text = row["Pk_num_dpi"].ToString();
                txt_nombre.Text = row["ren_nombres"].ToString();
                txt_genero.Text = row["ren_genero"].ToString();
                txt_edad.Text = row["ren_edad"].ToString();
                txt_DPIC.Text = row["ren_dpi"].ToString();

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

        // Método para generar números aleatorios con la cantidad de cifras especificada
        private string GenerarNumero8Cifras(int cifras)
        {
            Random random = new Random();
            int min = (int)Math.Pow(10, cifras - 1);
            int max = (int)Math.Pow(10, cifras) - 1;
            return random.Next(min, max).ToString();
        }

        private string GenerarNumero7Cifras()
        {
            Random random = new Random();
            return random.Next(1000000, 9999999).ToString();
        }

        private async void btn_generacion_Click(object sender, EventArgs e)
        {

            // Generar número de 8 cifras
            string numero8Cifras = GenerarNumero8Cifras(8);
            txt_NoBoleta.Text = numero8Cifras;

            // Generar número de 7 cifras
            string numero7Cifras = GenerarNumero7Cifras();
            txt_NoCGC.Text = numero7Cifras;

            string conceptos = txt_concepto.Text;
            string tipoPago = txt_tipoPago.Text;
            string IDPasaporte = txt_IDpasaport.Text;
            string NombrePasaporte = txt_pasaporteSeleccionado.Text;
            string tasa = txt_tasaPromedio.Text;
            string Preciodolar = txt_precioDolar.Text;
            string Precioquetzal = txt_precioQuetzal.Text;
            string AñosDuracion = txt_añosDuracion.Text;
            string DPI = txt_DPIC.Text;
            string IDDPI = txt_identificadorDPI.Text;
            string NombrePersona = txt_nombre.Text;
            string numeroBoleta = txt_NoBoleta.Text;
            string numeroCGC = txt_NoCGC.Text;


            frmConfirmacionBoleta form2 = new frmConfirmacionBoleta();

            
            form2.txt_conceptoBoleta.Text = conceptos;
            form2.txt_tipoBoleta.Text = tipoPago;
            form2.txt_tipoBoleta.Text = tipoPago;
            form2.txt_IDPasaporte.Text = IDPasaporte;
            form2.txt_pasaporteSelec.Text = NombrePasaporte;
            form2.txt_Precio3.Text = tasa;
            form2.txt_Precio2.Text = Preciodolar;
            form2.txt_Precio1.Text = Precioquetzal;
            form2.txt_pagoAños.Text = AñosDuracion;
            form2.txt_DPISelect.Text = DPI;
            form2.txt_IDPersona.Text = IDDPI;
            form2.txt_NombreAsignado.Text = NombrePersona;
            form2.txt_NoBoletaSelet.Text = numeroBoleta;
            form2.txt_NoCGCSelect.Text = numeroCGC;


            await Task.Delay(2000);
            form2.Show();

            txt_concepto.Text = "";
            txt_tipoPago.Text = "";
            txt_IDpasaport.Text = "";
            txt_pasaporteSeleccionado.Text = "";
            txt_tasaPromedio.Text = "";
            txt_precioDolar.Text = "";
            txt_precioQuetzal.Text = "";
            txt_añosDuracion.Text = "";
            txt_DPIC.Text = "";
            txt_identificadorDPI.Text = "";
            txt_nombre.Text = "";
            txt_NoBoleta.Text = "";
            txt_NoCGC.Text = "";
            txt_edad.Text = "";
            txt_genero.Text = "";

            cb_dpi.SelectedIndex = -1;
            cb_pasaporte.SelectedIndex = -1;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_concepto.Text = "";
            txt_tipoPago.Text = "";
            txt_IDpasaport.Text = "";
            txt_pasaporteSeleccionado.Text = "";
            txt_tasaPromedio.Text = "";
            txt_precioDolar.Text = "";
            txt_precioQuetzal.Text = "";
            txt_añosDuracion.Text = "";
            txt_DPIC.Text = "";
            txt_identificadorDPI.Text = "";
            txt_nombre.Text = "";
            txt_NoBoleta.Text = "";
            txt_NoCGC.Text = "";
            txt_edad.Text = "";
            txt_genero.Text = "";

            cb_dpi.SelectedIndex = -1;
            cb_pasaporte.SelectedIndex = -1;

        }
    }
}
