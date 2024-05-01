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

namespace CapaVista_SisB
{
    public partial class frmDeposito : Form
    {
        CapaControlador_SisB.WidgetHelper whelper;
        CapaControlador_SisB.Controlador ctrl;
        public int accId;
        public frmDeposito()
        {
            InitializeComponent();
            this.whelper = new WidgetHelper();
            this.ctrl = new CapaControlador_SisB.Controlador();
            this._init();
            accId = Convert.ToInt32(Seguridad_Controlador.Controlador.GetHash(Seguridad_Controlador.Controlador.idUser));
        }

        public void _init()
        {
            this.whelper.fillAccountsCmb(cmb_cuenta, accId);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = txt_cuenta.Text;
            this.ctrl.saveFriendAccount(code, accId);
            MessageBox.Show("Cuenta agregada correctamente");
            this._init();
            txt_cuenta.Text = "";
        }

        private void txt_cuenta_Enter(object sender, EventArgs e)
        {
            txt_cuenta.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = cmb_cuenta.SelectedText.Trim();
            selected = selected.Split('-')[0];
            Console.WriteLine(selected);
            this.ctrl.makeTransaction(selected, accId, Convert.ToDouble(txt_monto.Text));
            MessageBox.Show("Transaccion realizada");
        }
    }
}
