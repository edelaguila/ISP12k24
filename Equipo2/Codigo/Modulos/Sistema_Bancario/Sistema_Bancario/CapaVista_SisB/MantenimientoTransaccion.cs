using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
namespace CapaVista_SisB
{
    public partial class MantenimientoTransaccion : Form
    {
        Seguridad_Controlador.Controlador ctrl;
        public MantenimientoTransaccion()
        {
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("tbl_mantenimientos_tipo_movimiento", this, "8001");
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ((TextBox)sender).Text = "1";
            }
        }

        private void cb_tipoMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoMov.SelectedItem != null)
            {
                if (cb_tipoMov.SelectedItem.ToString().Equals("Activo"))
                {
                    txt_valorTrans.Text = "1";
                }
                else
                {
                    txt_valorTrans.Text = "0";
                }
            }
        }

        private void MantenimientoTransaccion_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_tipoMov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
