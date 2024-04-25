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
    public partial class PagoServicios : Form
    {
        Seguridad_Controlador.Controlador ctrl;
        public PagoServicios()
        {
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("tbl_cuenta", this, "8003");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FUNCIONES PARA EL BOTON BUSCAR

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FUNCIONES PARA EL BOTON PAGAR

        }
    }
}
