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

        public void ActualizarDGV(string tbl, int mode = 1)
        {
            if (mode == 1)
            {

                DataTable dt = cn.llenarTablas(tbl);
                dgv_trasladoProducto.DataSource = dt;
            }
            else
            {
                DataTable dt = TrasladoControlador.llenarExistencias();
                dgv_trasladoProducto.DataSource = dt;
            }
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.ActualizarDGV("tbl_trasladoprod", cb_modo.SelectedIndex);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_modo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarDGV("tbl_trasladoprod", cb_modo.SelectedIndex);
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            //Reportes.frmReporteTrasladoDeProducto rpt = new Reportes.frmReporteTrasladoDeProducto();
            //rpt.ShowDialog();
        }

        private void btn_ayudas_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"..\..\..\..\..\..\..\Ayuda\Modulos\Ayudas\AyudasByTech.chm";
            Help.ShowHelp(this, rutaAyuda, "TrasladoDeProducto.html");
        }
    }
}