using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

using CapaModelo_SisB;

namespace CapaVista_SisB
{
    public partial class PagoServicios : Form
    {
        Seguridad_Controlador.Controlador ctrl;

        private AccountSentence accountSentence;
        public PagoServicios()
        {
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();

            this.accountSentence = new AccountSentence();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FUNCIONES PARA EL BOTON BUSCAR
            // Busqueda en Base a Número de Cliente
            string accountNit = txt_noCliente.Text;

            // Función para llamar las facturas con el Número especifico
            CapaModelo_SisB.InvoiceSentence invoiceSentence = new CapaModelo_SisB.InvoiceSentence();
            // Listarlas para colocarlas en el Datagridview
            List<Invoice> invoices = invoiceSentence.GetInvoicesByAccountNit(accountNit);

            if (invoices.Count == 0)
            {
                MessageBox.Show("No se encontraron facturas para el número de cliente proporcionado.");
            }
            else
            {
                dataGridView1.DataSource = invoices;
            }

            CalcularTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FUNCIONES PARA EL BOTON PAGAR
            try
            {

                string accountNit = txt_noCliente.Text;
                double amountToPay = ObtenerMontoAPagar();

                // Verificar si el pago es válido
                CapaModelo_SisB.InvoiceSentence invoiceSentence = new CapaModelo_SisB.InvoiceSentence();
                bool paymentViability = accountSentence.checkPaymentViability(accountNit, amountToPay);
                if (!paymentViability)
                {
                    MessageBox.Show("El pago no es viable. Saldo insuficiente en la cuenta.");
                    return;
                }

                // Realizar el pago del Servicio
                accountSentence.makeServicePayment(accountNit, amountToPay);
                MessageBox.Show("Pago realizado exitosamente.");

                // Cambiar el estado de las Facturas
                List<Invoice> invoices = invoiceSentence.GetInvoicesByAccountNit(accountNit);
                foreach (Invoice invoice in invoices)
                {
                    invoiceSentence.changeInvoiceStatus(invoice.id);
                }

                // Actualizar la interfaz de usuario o realizar otras acciones necesarias
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message);
            }
        }
        private double ObtenerMontoAPagar()
        {
            // Verificar si el TextBox tiene un valor válido
            if (!double.TryParse(txt_totalPagar.Text, out double monto))
            {
                // Mostrar un mensaje de error si el valor ingresado no es válido
                MessageBox.Show("Por favor, ingrese un monto válido.");
                // En caso de no ser válido
                return 0.0;
            }

            return monto;
        }

        private void CalcularTotal()
        {
            double total = 0.0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Verificar si la fila no es nueva y las celdas no están vacías
                if (!row.IsNewRow && row.Cells["Amount"].Value != null)
                {
                    // Verificar Estado
                    bool isChecked = (bool)row.Cells["Status"].FormattedValue;

                    if (!isChecked)
                    {
                        if (double.TryParse(row.Cells["Amount"].Value.ToString(), out double valor))
                        {
                            // Suma el valor al total
                            total += valor;
                        }
                    }
                }
            }

            // Muestra el total en el TextBox
            txt_totalPagar.Text = total.ToString();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "id",
                HeaderText = "ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ServiceID",
                DataPropertyName = "idService",
                HeaderText = "Service ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ServiceName",
                DataPropertyName = "serviceName",
                HeaderText = "Service Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientNit",
                DataPropertyName = "clientNit",
                HeaderText = "Client NIT"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                DataPropertyName = "amount",
                HeaderText = "Amount"
            });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Status",
                DataPropertyName = "status",
                HeaderText = "Status"
            });
        }

        private void PagoServicios_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }
    }
}
