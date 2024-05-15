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
{
    public partial class tipodecombio : Form
    {
        Controlador cn = new Controlador();
        public tipodecombio()
        {
            InitializeComponent();
            LlenarCombomoneda();
            LlenarCombomoneda1();
            actualizardatagriew();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string emp = "tbl_tipocambio";
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenartablatipodecambio(emp);
            dataGridView1.DataSource = dt;

        }


        public void LlenarCombomoneda()
        {
            List<string> concepto = cn.llenarCombo("nombre", "moneda");
            cb_cuenta.Items.Clear();
            cb_cuenta.Items.AddRange(concepto.ToArray());



        }

        public void LlenarCombomoneda1()
        {
            List<string> concepto = cn.llenarCombo("nombre", "moneda");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(concepto.ToArray());
        }



        public void BuscarDetallemoneda()
        {
            // Obtener el valor del ID del banco desde el TextBox correspondiente

            string tabla = "moneda";

            string columna = "nombre";

            string dato = (cb_cuenta.SelectedItem != null) ? cb_cuenta.SelectedItem.ToString() : string.Empty;

            // Realizar la búsqueda en la base de datos
            DataTable dt = cn.Buscar(tabla, columna, dato);

            // Verificar si se encontraron resultados
            if (dt.Rows.Count > 0)
            {
                // Mostrar los detalles del banco encontrados en los TextBox correspondientes
                txt_IDBanco.Text = dt.Rows[0]["idmoneda"].ToString();
                txtsimbolo.Text = dt.Rows[0]["simbolo"].ToString();
                txtnombre.Text = dt.Rows[0]["nombre"].ToString();
                txtnombre1.Text = dt.Rows[0]["nombre"].ToString();
                txtpais.Text = dt.Rows[0]["Pais_origen"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
            }



        }
        public void BuscarDetallemoneda1()
        {
            // Obtener el valor del ID del banco desde el TextBox correspondiente

            string tabla = "moneda";

            string columna = "nombre";

            string dato = (comboBox1.SelectedItem != null) ? comboBox1.SelectedItem.ToString() : string.Empty;

            // Realizar la búsqueda en la base de datos
            DataTable dt = cn.Buscar(tabla, columna, dato);

            // Verificar si se encontraron resultados
            if (dt.Rows.Count > 0)
            {
                // Mostrar los detalles del banco encontrados en los TextBox correspondientes

                txtnombre1.Text = dt.Rows[0]["nombre"].ToString();


            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }

        private void cb_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetallemoneda();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            string contenido1 = cantidad1.Text;
            string contenido2 = valor.Text;

            // Convertir los contenidos a números decimales y realizar la multiplicación
            if (decimal.TryParse(contenido1, out decimal numero1) && decimal.TryParse(contenido2, out decimal numero2))
            {
                // Realizar la multiplicación
                decimal resultado = numero1 * numero2;

                // Mostrar el resultado en txtBox3
                total.Text = resultado.ToString("0.00"); // Formatear el resultado según sea necesario
            }
            else
            {
                // Mostrar mensaje de error si los contenidos no son números válidos
                MessageBox.Show("Los valores ingresados no son números válidos.");
            }

            // Formatear el resultado según sea necesario
            // Obtener el contenido de los TextBox
            string cantidad = cantidad1.Text; // Cantidad ingresada en el primer TextBox
            string cantidadEquivalente = total.Text; // Cantidad equivalente ingresada en el segundo TextBox
            string simboloMoneda = txtsimbolo.Text; // Símbolo de la moneda desde txtSimbolo
            string paisMoneda = txtpais.Text; // País de la moneda desde txtPais
            string seleccionComboBox = comboBox1.SelectedItem?.ToString(); // Obtener el elemento seleccionado

            // Construir el mensaje descriptivo
            string mensaje = $"{cantidad} {simboloMoneda} ({paisMoneda}) equivale a {cantidadEquivalente} {seleccionComboBox}";

            // Mostrar el mensaje en el Label
            lblResultado.Text = mensaje;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        public void GuardarDatos()
        {
            string tabla = "tbl_tipocambio";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            string monedaOrigen = txtnombre.Text;
            valores.Add("moneda_origen", monedaOrigen);

            string monedaDestino = txtnombre1.Text;
            valores.Add("moneda_destino", monedaDestino);


            valores.Add("valor_calculado", double.Parse(valor.Text));
            valores.Add("total_calculado", double.Parse(total.Text));
            valores.Add("cantidad", double.Parse(cantidad1.Text));
            valores.Add("fecha", dtp_fecha.Value);
            cn.GuardarDatos(tabla, valores);

            MessageBox.Show("Datos guardados");
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetallemoneda1();
        }
    }
}
