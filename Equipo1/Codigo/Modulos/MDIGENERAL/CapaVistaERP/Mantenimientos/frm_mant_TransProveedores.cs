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
    public partial class frm_Mant_TransProveedores : Form
    {
        public frm_Mant_TransProveedores()
        {
            InitializeComponent();
            this.navegador1.config("tbl_transprov", this, "");
            llenarcombo();
            llenarcombo2();
        }
        public void llenarcombo()
        {
            cb_tipotrans.Items.Add("Cargo");
            cb_tipotrans.Items.Add("Abono");
        }

        public void llenarcombo2()
        {
            cb_estadoprov.Items.Add(0);
            cb_estadoprov.Items.Add(1);
        }
        private void frm_Mant_TransProveedores_Load(object sender, EventArgs e)
        {
           

           
        }

        private void cb_tipotrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
