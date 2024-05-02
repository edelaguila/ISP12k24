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
{// carlos enrique guzman cabrera
    public partial class frmMantenimientoBanco : Form
    {
        public frmMantenimientoBanco()
        {
            //8007
            InitializeComponent();
            this.navegador1.config("tbl_banco", this, "8007");
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_estado.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_estado.SelectedItem.ToString();
            txt_estado.Text = opcionSeleccionada;
        }
    }
}
