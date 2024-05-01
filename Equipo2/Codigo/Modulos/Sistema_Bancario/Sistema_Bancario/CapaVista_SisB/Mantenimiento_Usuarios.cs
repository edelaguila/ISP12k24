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
    public partial class Mantenimiento_Usuarios : Form
    {
        //codigo de configuracion al navegador
        public Mantenimiento_Usuarios()
        {
            //conexion a tabla 
            InitializeComponent();
            navegador1.config("tbl_usuarios", this, "8003");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
