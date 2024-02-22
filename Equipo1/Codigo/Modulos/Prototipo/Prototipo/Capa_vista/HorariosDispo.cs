using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;


namespace Vista_PrototipoMenu
{
    public partial class HorariosDispo : Form
    {
        Controlador ctrl = new Controlador();
        public HorariosDispo()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;
            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                labelhora.Text = radioButton.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //variables para agendar cita.



            //para reagendar
                string cita = lblidcita.Text;
                int citas = int.Parse(lblidcita.Text);
                string dep = labeldep.Text;
                string fecha = labelfecha.Text;
                string muni = labelmuni.Text;
                string pais = labelpais.Text;
                string hora = labelhora.Text;

            bool exito = ctrl.ActualizarCitas(citas, fecha, hora,dep, muni  );

            if (exito)
            {
                MessageBox.Show("Cita actualizada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la cita");
            }


        }
    }
}
