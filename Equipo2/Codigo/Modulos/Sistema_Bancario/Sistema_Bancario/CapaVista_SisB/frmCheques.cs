using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_SisB;

namespace CapaVista_SisB
{
    public partial class frmCheques : Form
    {
        public CheckbookAndCheckController controller = new CheckbookAndCheckController();
        public frmCheques()
        {
            InitializeComponent();
        }

        private void frmCheques_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int Id = CheckbookAndCheckController.getCheckbookId(textBox1.Text);
            if (Id == -1)
            {
                MessageBox.Show("Chequera no encontrada, consulte con el administrador para crearle una");
            }
            if (CheckbookAndCheckController.CheckbookContainChecks(Id))
            {
                txt_cant1.Enabled = false;
                lbl_fill.Text = Id.ToString();
                btn_fill.Enabled = false;
            }
        }

        private void ch_deposito_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_deposito.Checked)
            {
                ch_retiro.Checked = false;
                changeStateDeposito(true);
                changeStateRetiro(false);
            }
        }

        public void changeStateRetiro(bool state)
        {
            txt_monto1.Enabled = state;
            lbl_cheque.Enabled = state;
            lbl_monto.Enabled = state;
            txt_cheque.Enabled = state;
        }

        public void changeStateDeposito(bool state)
        {
            txt_monto2.Enabled = state;
            txt_cuenta2.Enabled = state;
            lbl_destino.Enabled = state;
            lbl_debitar.Enabled = state;
            txt_cheque2.Enabled = state;
            label4.Enabled = state;
        }

        private void ch_retiro_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_retiro.Checked)
            {
                ch_deposito.Checked = false;
                changeStateDeposito(false);
                changeStateRetiro(true);
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            CheckbookAndCheckController.createCheckbook(textBox1.Text);
            CheckbookAndCheckController.generateChecksFromCheckbook(CheckbookAndCheckController.getCheckbookId(textBox1.Text), Convert.ToInt32(txt_cant1.Text));
            MessageBox.Show("Chequerea creada correctamente!");
        }

        private void btn_cobro1_Click(object sender, EventArgs e)
        {
            string checkNo = txt_cheque.Text;
            string amount = txt_monto1.Text;
            CheckbookAndCheckController.updateCheck(Convert.ToInt32(checkNo), Convert.ToDouble(amount));
            TransactionController.makeTransaction(textBox1.Text, Convert.ToDouble(amount), -1);
            MessageBox.Show("Cobro Relizado");
        }

        private void btn_cobro2_Click(object sender, EventArgs e)
        {
            string accountNo = txt_cuenta2.Text;
            string amount = txt_monto2.Text;
            TransactionController.makeTransaction(accountNo, Convert.ToDouble(amount));
            MessageBox.Show("Deposito realizado");
            CheckbookAndCheckController.updateCheck(Convert.ToInt32(txt_cheque2.Text), Convert.ToDouble(amount));
        }
    }
}
