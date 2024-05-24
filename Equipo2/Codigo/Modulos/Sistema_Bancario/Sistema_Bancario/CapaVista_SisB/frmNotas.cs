using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_SisB.Templates;
using CapaControlador_SisB;

namespace CapaVista_SisB
{
    public partial class frmNotas : Form
    {
        Controlador cn = new Controlador();
        public List<Innvoice> invoices;
        public frmNotas()
        {
            InitializeComponent();
        }

        public void fillCombo()
        {
            string accountNumber = txt_Cuenta.Text;
            invoices = Controlador.GetFactura(accountNumber);
            foreach (Innvoice inv in invoices)
            {
                this.cmb_facturas.Items.Add(inv.Id);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.fillCombo();
        }

        private void ch_credito_CheckedChanged(object sender, EventArgs e)
        {
            this.groupB_credito.Enabled = true;
            this.groupB_debito.Enabled = false;
            ch_debito.Checked = false;
        }

        private void ch_debito_CheckedChanged(object sender, EventArgs e)
        {
            this.groupB_credito.Enabled = false;
            this.groupB_debito.Enabled = true;
            ch_credito.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_Cuenta.Text;
            double monto = ch_debito.Checked ? Convert.ToDouble(txt_descuento.Text) : Convert.ToDouble(txt_aumento.Text);
            TransactionController.makeTransaction(accountNumber, monto, -1);
            MessageBox.Show("Accion realizada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string monto = ch_credito.Checked ? txt_aumento.Text : "-" + txt_descuento.Text;
            DocumentController.makeTransactionDocument(txt_Cuenta.Text, monto);  
        }
    }
}
