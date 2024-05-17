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
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Definir el nombre de la tabla
            string tabla = "tbl_tipocambio";

            // Crear un diccionario para almacenar los valores
            Dictionary<string, object> valores = new Dictionary<string, object>();

            // Capturar los valores de los controles de la interfaz de usuario
            string monedaOrigen = txtnombre.Text;
            valores.Add("moneda_origen", monedaOrigen);

            string monedaDestino = txtnombre1.Text;
            valores.Add("moneda_destino", monedaDestino);

            double valorCalculado = double.Parse(valor.Text);
            valores.Add("valor_calculado", valorCalculado);

            double totalCalculado = double.Parse(total.Text);
            valores.Add("total_calculado", totalCalculado);

            double cantidad = double.Parse(cantidad1.Text);
            valores.Add("cantidad", cantidad);

            DateTime fecha = dtp_fecha.Value;
            valores.Add("fecha", fecha);

            // Llamar al método del controlador para guardar los datos
            cn.InsertarTipoCambio(fecha, monedaOrigen, monedaDestino, cantidad, valorCalculado, totalCalculado);

            // Mostrar mensaje de éxito
            MessageBox.Show("Datos guardados exitosamente en la tabla tipo de cambio.");

        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            BuscarDetallemoneda1();
            // Obtener los valores seleccionados en los ComboBox
            string monedaOrigen = cb_cuenta.SelectedItem?.ToString();
            string monedaDestino = comboBox1.SelectedItem?.ToString();

            // Verificar si los valores seleccionados son válidos
            if (!string.IsNullOrEmpty(monedaOrigen) && !string.IsNullOrEmpty(monedaDestino))
            {
                // Realizar la búsqueda del detalle de la moneda de origen
              

                // Asignar automáticamente el valor según las selecciones de moneda
                if (monedaOrigen == "Dólar" && monedaDestino == "Quetzales")
                {
                    // Asignar el valor 7.77 al TextBox "valor"
                    valor.Text = "7.77";
                }
                else if (monedaOrigen == "Euros" && monedaDestino == "Quetzales")
                {
                    // Asignar el valor 8.41 al TextBox "valor"
                    valor.Text = "8.41";
                }
                else if (monedaOrigen == "Quetzales" && monedaDestino == "Dólar")
                {
                    // Asignar el valor 0.13 al TextBox "valor"
                    valor.Text = "0.13";
                }
                else if (monedaOrigen == "Quetzales" && monedaDestino == "Euros")
                {
                    // Asignar el valor 0.12 al TextBox "valor"
                    valor.Text = "0.12";
                }
                else if (monedaOrigen == "Euros" && monedaDestino == "Dólar")
                {
                    // Asignar el valor 1.08 al TextBox "valor"
                    valor.Text = "1.08";
                }
                else if (monedaOrigen == "Dólar" && monedaDestino == "Euros")
                {
                    // Asignar el valor 0.93 al TextBox "valor"
                    valor.Text = "0.93";
                }
                else
                {
                    // Limpiar el TextBox "valor" si no se cumple ninguna condición
                    valor.Text = string.Empty;
                }

                // Realizar el cálculo si es necesario y mostrar el resultado

            }
            else
            {
                MessageBox.Show("Selecciona las monedas de origen y destino para realizar la conversión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cb_cuenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BuscarDetallemoneda();
                // Verificar si el elemento seleccionado en cb_cuenta es "Dolar"
                if (cb_cuenta.SelectedItem?.ToString() == "Dólar")
                {
                // Asignar automáticamente el valor 7.77 al TextBox "valor"
                cantidad1.Text = "1";
                }
            if (cb_cuenta.SelectedItem?.ToString() == "Quetzales")
            {
                // Asignar automáticamente el valor 7.77 al TextBox "valor"
                cantidad1.Text = "1";
            }
            if (cb_cuenta.SelectedItem?.ToString() == "Euros")
            {
                // Asignar automáticamente el valor 7.77 al TextBox "valor"
                cantidad1.Text = "1";
            }

        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.frmReporteTipoCambio Reporte = new Reportes.frmReporteTipoCambio();
            Reporte.ShowDialog();
        }
    }
}
