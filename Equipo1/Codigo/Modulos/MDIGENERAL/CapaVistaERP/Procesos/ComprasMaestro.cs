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
    public partial class ComprasMaestro : Form
    {
        private string idord = "";
        private string fechaS = "";
        private string fechaE = "";
        private string solicitante = "";
        private string proveedor = "";
        Controlador cn = new Controlador();
        public ComprasMaestro()
        {
            InitializeComponent();
            actualizardatagridview();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            Compras Compras = new Compras(idord, fechaS, fechaE, solicitante, proveedor);
            Compras.Show();
        }
        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTablas("tbl_compras");
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
