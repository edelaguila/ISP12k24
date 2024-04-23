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
using CapaControladorERP;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_Mant_TransProveedores : Form
    {
        Controlador cn = new Controlador();
        //private int valor = 1;

        public frm_Mant_TransProveedores()
        {
            InitializeComponent();
            this.navegador1.config("tbl_transprov", this, "8002");
            CotiCombo();
            // id_transprov.Text = valor.ToString();
            comboBox3.Items.Add("Activo");
            comboBox3.Items.Add("Inactivo");
        }
        public void CotiCombo()
        {
            try
            {
                List<string> producto = cn.ComboFill("id_prov", "tbl_proveedor");
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(producto.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        }

        private void frm_Mant_TransProveedores_Load(object sender, EventArgs e)
        {
        }

        private void cb_tipotrans_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbl_proveedor_id_prov.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo_transprov.Text = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado_transprov.Text = comboBox3.SelectedItem.ToString();
            
        }
    }
}
