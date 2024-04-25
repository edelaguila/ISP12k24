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
    public partial class frmBitacoraMovimientoDeBancos : Form
    {
        Controlador cn = new Controlador();
        public frmBitacoraMovimientoDeBancos()
        {
            InitializeComponent();
        }
        string emp = "tbl_movimientodebancos";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenartablabitacoraMB(emp);
            dtTabla.DataSource = dt;

        }

        public void BuscarPorFecha()
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value;
            string strfiltro = fechaSeleccionada.ToString("yyyy-MM-dd");
            DataTable dt = cn.BuscarMB(strfiltro);
            dtTabla.DataSource = dt;
        }

        private async void btn_regresar_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarPorFecha();
        }
    }
}
