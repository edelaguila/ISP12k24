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
    public partial class frm_pedidos : Form

    {
        Controlador cn = new Controlador();
        public frm_pedidos()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime nuevaFecha = fechaSeleccionada.AddDays(15);
            dateTimePicker2.Value = nuevaFecha;
        }

        private void frm_pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_id_vendedor.Text, out int idVendedor))
                {

                    Vendedor vendedorEncontrado = cn.BuscarVendedorPorID(idVendedor);


                    if (vendedorEncontrado != null)
                    {
                        foreach (Control control in groupBox3.Controls)
                        {
                            if (control is TextBox)
                            {
                                TextBox textBox = (TextBox)control;
                                if (textBox.Tag != null && textBox.Tag.ToString() != "")
                                {
                                    string campo = textBox.Tag.ToString();
                                    if (campo == "nombre_vend")
                                    {
                                        textBox.Text = vendedorEncontrado.Nombre;
                                    }
                                    else if (campo == "telefono_vend")
                                    {
                                        textBox.Text = vendedorEncontrado.Telefono;
                                    }
                                    else if (campo == "estado_vend")
                                    {
                                        textBox.Text = vendedorEncontrado.Estado;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Vendedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("ID de vendedor no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
    }

