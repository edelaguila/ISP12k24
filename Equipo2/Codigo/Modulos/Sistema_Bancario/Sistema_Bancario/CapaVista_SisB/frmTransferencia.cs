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
using CapaModelo_SisB.Templates;

namespace CapaVista_SisB
{
    public partial class frmTransferencia : Form
    {
        
        CapaControlador_SisB.AccountControler ctrl;
        public int accId;
        public List<Cuenta> cuentas;
        public List<Cuenta> CuentasAmigas;
        public frmTransferencia()
        {
            InitializeComponent();
            this.ctrl = new CapaControlador_SisB.AccountControler();
            accId = Convert.ToInt32(Seguridad_Controlador.Controlador.GetHash(Seguridad_Controlador.Controlador.idUser));
            cuentas = this.ctrl.getAccountsFromUser(accId);
            fillCombo(cuentas, cmb_cuentas);
            
        }
        
        public void fillCombo(List<Cuenta> _cuentas, ComboBox cmb)
        {
            foreach (Cuenta cuenta in _cuentas)
            {

                cmb.Items.Add(cuenta.nombre+ "--"+ cuenta.numero);


            }

        }

        private void cmb_cuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmb_cuentas.SelectedIndex;
            lbl_saldo.Text = cuentas[index].saldo.ToString();
            Controlador.GetUserFriendAccount(cuentas[index]);
            CuentasAmigas = Controlador.GetUserFriendAccount(cuentas[index]);
            fillCombo(CuentasAmigas, cmb_amigas);
        }

        private void cmb_amigas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numero = CuentasAmigas[cmb_amigas.SelectedIndex].numero;
            double monto = Convert.ToDouble(txt_monto.Text);
            TransactionController.makeTransaction(numero, monto);
            TransactionController.makeTransaction(cuentas[cmb_cuentas.SelectedIndex].numero, monto, -1);
            MessageBox.Show("Transaccion Realizada con Exito");
        }
    }
}
