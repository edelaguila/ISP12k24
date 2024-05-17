using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_SisB
{
    public partial class Mantenimiento_Cuenta : Form
    {
        public Mantenimiento_Cuenta()
        {
            InitializeComponent();
            navegador1.config("tbl_cuenta", this, "8003");
            DatosdeCmb();
            DatosdeCmb1();


        }
        public void DatosdeCmb()
        {
            if (cmb_tipo_cuenta.SelectedIndex == 0) {

                textBox3.Text = "1";
            
            }else if(cmb_tipo_cuenta.SelectedIndex == 1)
            {

                textBox3.Text = "2";

            }

        }
        public void DatosdeCmb1()
        {
            if (cmb_tipo_moneda.SelectedIndex == 0)
            {

                textBox2.Text = "1";

            }
            else if (cmb_tipo_moneda.SelectedIndex == 1)
            {

                textBox2.Text = "2";

            }
            else if (cmb_tipo_moneda.SelectedIndex == 2)
            {

                textBox2.Text = "3";

            }

        }


        private void cmb_tipo_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosdeCmb();
        }

        private void cmb_moneda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tipo_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosdeCmb1();
        }
    }
}
