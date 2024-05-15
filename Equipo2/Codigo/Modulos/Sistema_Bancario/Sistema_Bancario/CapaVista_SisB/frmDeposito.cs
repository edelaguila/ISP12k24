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
using Seguridad_Controlador;
using CapaModelo_SisB.Libraries;
using CapaModelo_SisB.Templates;

namespace CapaVista_SisB
{
    public partial class frmDeposito : Form
    {
        CapaControlador_SisB.WidgetHelper whelper;
        CapaControlador_SisB.AccountControler ctrl;
        public int accId;
        public AccountTransactions transaction;
        public frmDeposito()
        {
            InitializeComponent();
            this.whelper = new WidgetHelper();
            this.ctrl = new CapaControlador_SisB.AccountControler();
            accId = Convert.ToInt32(Seguridad_Controlador.Controlador.GetHash(Seguridad_Controlador.Controlador.idUser));
            Cuenta account = this.ctrl.getAccountsFromUser(accId)[0];
            transaction = new AccountTransactions(account.id, account.nombre, account.numero, account.saldo);
            this.fillCmb();
        }

        public void fillCmb()
        {
            //this.cmb_cuenta.Items.Clear();
            foreach (Cuenta acc in this.transaction.friend_accounts)
            {
                this.cmb_cuenta.Items.Add(acc.nombre);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.transaction.addFriendAccount(txt_cuenta.Text);
            this.fillCmb();
            MessageBox.Show("Cuenta amiga agregada!");
        }

        private void txt_cuenta_Enter(object sender, EventArgs e)
        {
            txt_cuenta.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*string selected = cmb_cuenta.SelectedText.Trim();
            selected = selected.Split('-')[0];
            Console.WriteLine(selected);
            this.ctrl.makeTransaction(selected, accId, Convert.ToDouble(txt_monto.Text));
            MessageBox.Show("Transaccion realizada")*/
            double amount = Convert.ToDouble(txt_monto.Text);
            this.transaction.makeTransactionWithFriendAccount(cmb_cuenta.SelectedIndex, amount);
            MessageBox.Show("Deposito realizado correctamente!");
        }
    }
}
