using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;

//Programado por: Carol Chuy 
namespace CapaVistaERP.Procesos
{
    public partial class FacturaporPagarMaestro : Form
    {
        private string idcompra = "";
        private string fechaV = "";
        private string proveedorfact = "";
        Controlador cn = new Controlador();
        public FacturaporPagarMaestro()
        {
            InitializeComponent();
            actualizardatagridview();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            FacturaporPagar FacturaporPagar = new FacturaporPagar(idcompra, fechaV, proveedorfact);
            FacturaporPagar.Show();
        }
        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTablas("tbl_facturaxpagar");
            dataGridView1.DataSource = dt;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
