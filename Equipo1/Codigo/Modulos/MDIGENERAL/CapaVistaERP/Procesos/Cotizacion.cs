using CapaControladorERP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Procesos
{
    public partial class Cotizacion : Form
    {
        Controlador cn = new Controlador();
        public Cotizacion()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
          
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime nuevaFecha = fechaSeleccionada.AddDays(15);
            dateTimePicker2.Value = nuevaFecha;
            CotiCombo();
        }
       public void CotiCombo()
        {
            try { 
            List<string> producto = cn.ComboFill("nombre_prod", "tbl_producto");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(producto.ToArray());
            }
            catch(Exception e) {
                MessageBox.Show("error" + e);
                    }

        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime nuevaFecha = fechaSeleccionada.AddDays(15);
            dateTimePicker2.Value = nuevaFecha;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            string nombreProducto = comboBox1.SelectedItem?.ToString();
            double precioUnitario = 0.0;
            int cantidad = 0;

            if (!string.IsNullOrEmpty(nombreProducto) && !string.IsNullOrEmpty(txt_cant.Text))
            { 
                precioUnitario = cn.GetPrecio(nombreProducto);
                if (int.TryParse(txt_cant.Text, out cantidad))
                {
                    double total = cantidad * precioUnitario;
                    lbl_precioUni.Text = precioUnitario.ToString();
                    lbl_total.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es válida. Por favor, ingrese un número entero.");
                }
            }
            else
            {
            }
        }

        private void txt_cant_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        //boton para guardar los datos del cliente
        private void button3_Click(object sender, EventArgs e)
        {
            string nombre_cl = txt_nombre_cl.Text;
            string apellido_cl = txt_apellido_cl.Text;
            string direccion_cl = txt_direccion_cl.Text;
            string correo_cl = txt_correo_cl.Text;
            string telefono_cl = txt_telefono_cl.Text;
            cn.insertarCliente(nombre_cl, apellido_cl, direccion_cl, correo_cl, telefono_cl);

            MessageBox.Show("Datos Guardados prosiga con su cotizacion");

            cliente();

        }

       private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombreProducto = comboBox1.SelectedItem?.ToString();
            double precioUnitario = 0.0;
            int cantidad = 0;

            if (!string.IsNullOrEmpty(nombreProducto) && !string.IsNullOrEmpty(txt_cant.Text))
            {
                precioUnitario = cn.GetPrecio(nombreProducto);
                if (int.TryParse(txt_cant.Text, out cantidad))
                {
                    double total = cantidad * precioUnitario;
                    lbl_precioUni.Text = precioUnitario.ToString();
                    lbl_total.Text = total.ToString();

                    dataGridView1.Rows.Add(nombreProducto, cantidad, precioUnitario, total);
                    ActualizarSubtotal();
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es válida. Por favor, ingrese un número entero.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto y especifique la cantidad.");
            }
        }

        private void cliente()
        {
            string cliente = txt_nombre_cl.Text;
            string idClienteString = cn.obtenerCliente(cliente);

            if (!string.IsNullOrEmpty(idClienteString))
            {
                int idCliente = Convert.ToInt32(idClienteString);
                label16.Text = idCliente.ToString();
                Console.WriteLine("Nombre del cliente: " + cliente);
                Console.WriteLine("ID del cliente: " + idCliente);
            }
            else
            {
                label16.Text = "Cliente no encontrado";
                Console.WriteLine("Cliente no encontrado");
            }
        }
        private void ActualizarSubtotal()
        {
            double subtotal = 0.0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells["Total"].Value);
            }
            lbl_subTotal.Text = subtotal.ToString();
        }

        private void txt_nombre_cl_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no_coti = Convert.ToInt32(lblNoCoti.Text);
            string fechaini = dateTimePicker1.Text;
            string fechafin=dateTimePicker2.Text;

            cn.InsertarCoti(no_coti, fechaini, fechafin);
        }
    }
}
