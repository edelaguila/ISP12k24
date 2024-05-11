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

namespace CapaVistaERP.Procesos
{
    public partial class TrasladoDeProductoMaestro : Form
    {
        Controlador cn = new Controlador();

        public TrasladoDeProductoMaestro()
        {
            InitializeComponent();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            TrasladoDeProducto TrasladoDeProducto = new TrasladoDeProducto();
            TrasladoDeProducto.Show();
        }

        public void ActualizarDGV()
        {
            DataTable dt = cn.llenarTablas("tbl_trasladoprod");
            dgv_trasladoProducto.DataSource = dt;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
