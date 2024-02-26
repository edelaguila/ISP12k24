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


namespace CapaVista_MG2
{
    public partial class GP : Form
    {
        public GP()
        {
            Seguridad_Controlador.Controlador cont = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("tbl_boleta", this);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
