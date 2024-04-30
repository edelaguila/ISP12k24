using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_mant_vendedores : Form
    {
        public frm_mant_vendedores()
        {
            InitializeComponent();
            this.navegador1.config("tbl_vendedor", this, "8004");
            vendEST();
           
        }

        public void vendEST()
        {
            comboBox1.Items.Add("--Seleccione--");
            comboBox1.Items.Add("Activo");
            comboBox1.Items.Add("Inactivo");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado_vend.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
