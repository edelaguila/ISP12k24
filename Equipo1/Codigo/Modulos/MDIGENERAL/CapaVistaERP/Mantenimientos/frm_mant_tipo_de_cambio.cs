using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_mant_tipo_de_cambio : Form
    {
        public frm_mant_tipo_de_cambio()
        {
            InitializeComponent();
            this.navegador1.config("moneda", this, "8009");
            comboBox1.Items.Add("Quetzales");
            comboBox1.Items.Add("Dólar");
            comboBox1.Items.Add("Euros");
            comboBox2.Items.Add("Q");
            comboBox2.Items.Add("$");
            comboBox2.Items.Add("€");
            comboBox3.Items.Add("Activo");
            comboBox3.Items.Add("positivo");



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
