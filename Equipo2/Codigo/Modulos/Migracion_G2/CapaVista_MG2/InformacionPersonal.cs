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
    public partial class InformacionPersonal : Form
    {
        public Persona mipersona = new Persona();
        public InformacionPersonal()
        {
            InitializeComponent();
        }

        public void setData(Persona persona)
        {
            this.mipersona = persona;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mipersona.setData(cmb_pais.SelectedIndex + 1, txt_depa.Text, txt_muni.Text, txt_celu.Text,
                txt_tel.Text, txt_correo.Text, Convert.ToDouble(txt_altura.Text), cmb_tez.Text,
                cmb_ojos.Text, cmb_ocupacion.Text);
            frmCalendario frm = new frmCalendario();
            frm.setData(this.mipersona);
            frm.ShowDialog();
        }
    }
}
