using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_MG2.Templates;

namespace CapaVista_MG2
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(0, txt_nombre.Text, txt_nombre2.Text, txt_apellido.Text,
                txt_apellido2.Text, date_picker.Value, txt_num.Text, cmb_sex.SelectedIndex + 1,
                txt_nacionalidad.Text, cmb_sex.SelectedIndex + 1);
            InformacionPersonal info = new InformacionPersonal();
            info.setData(persona);
            info.Show();
        }
    }
}
