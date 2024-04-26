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
    public partial class frmProductos : Form
    {
        Controlador cn = new Controlador();
        public frmProductos()
        {
            InitializeComponent();
            this.navegador1.config("tbl_producto", this, "8005");
            CotiCombo();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
      
        }

        public void CotiCombo()
        {
            try
            {
                List<string> productoNom = cn.ComboFill("id_marca", "tbl_marcas");
                cb_MarcaProd.Items.Clear();
                cb_MarcaProd.Items.AddRange(productoNom.ToArray());

                //cb_LineaProd
                List<string> LineaNom = cn.ComboFill("id_linea", "tbl_lineas");
                cb_LineaProd.Items.Clear();
                cb_LineaProd.Items.AddRange(LineaNom.ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show("error" + e);
            }
        }

        private void cb_MarcaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = cb_MarcaProd.SelectedItem.ToString();
        }

        private void cb_LineaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = cb_LineaProd.SelectedItem.ToString();
        }
    }
}
