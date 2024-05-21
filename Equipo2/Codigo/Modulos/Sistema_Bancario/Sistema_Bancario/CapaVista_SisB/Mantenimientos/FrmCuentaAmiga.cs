using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_SisB.Libraries;
using CapaModelo_SisB.Templates;

namespace CapaVista_SisB.Mantenimientos
{
    public partial class FrmCuentaAmiga : Form
    {
        public CapaControlador_SisB.AccountControler ctrl;
        public List<Cuenta> userAccounts = new List<Cuenta>();
        public AccountTransactions acc;
        public FrmCuentaAmiga()
        {
            InitializeComponent();
            this.ctrl = new CapaControlador_SisB.AccountControler();
            string id = Seguridad_Controlador.Controlador.GetHash(Seguridad_Controlador.Controlador.idUser);
            this.userAccounts = this.ctrl.getAccountsFromUser(Convert.ToInt32(id));
            Cuenta current = this.userAccounts[0];
            this.acc = new AccountTransactions(current.id, current.nombre, current.numero, current.saldo);
            this.fillDataGrid();
        }



        public void fillDataGrid()
        {
            Console.WriteLine("debuging");
            Console.WriteLine(acc.nombre);
            Console.WriteLine(acc.friend_accounts.Count);
            this.dataGridView1.ColumnCount = 3;
            this.dataGridView1.Columns[0].Name = "ID";
            this.dataGridView1.Columns[1].Name = "Nombre";
            this.dataGridView1.Columns[2].Name = "Numero";
            foreach (Cuenta account in this.acc.friend_accounts)
            {
                this.dataGridView1.Rows.Add(account.id, account.nombre, account.numero);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ctrl.addFriendAccount(textBox1.Text, this.acc);
            this.dataGridView1.Rows.Clear();
            this.fillDataGrid();
            textBox1.Text = "";
            MessageBox.Show("Cuenta amiga agregada!");

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.acc.deleteFriendAccount(this.acc.id, Convert.ToInt32(Id));
            this.dataGridView1.Rows.Clear();
            this.fillDataGrid();
            MessageBox.Show("Cuenta amiga elimiminada");
        }
    }
}
