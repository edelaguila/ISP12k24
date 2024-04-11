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
    public partial class frmCuenta : Form
    {
        Seguridad_Controlador.Controlador ctrl;
        public frmCuenta()
        {
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("usuarios", this);
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
