using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frmMantenimientoMovimientoConcepto : Form
    {
        public frmMantenimientoMovimientoConcepto()
        {
            //8008
            InitializeComponent();
            this.navegador1.config("tbl_conceptomovimientodebancos", this, "8008");
        }

        private void cb_efecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_efecto.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_efecto.SelectedItem.ToString();
            txt_efecto.Text = opcionSeleccionada;
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_estado.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_estado.SelectedItem.ToString();
            txt_estado.Text = opcionSeleccionada;
        }

        private void frmMantenimientoMovimientoConcepto_Load(object sender, EventArgs e)
        {

        }
    }
}
