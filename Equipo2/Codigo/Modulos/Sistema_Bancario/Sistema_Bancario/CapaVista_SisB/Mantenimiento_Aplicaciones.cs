using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_SisB
{
    public partial class Mantenimiento_Aplicaciones : Form
    {
        public Mantenimiento_Aplicaciones()
        {
            InitializeComponent();
            this.navegador1.config("tbl_aplicaciones", this, "9001");
        }

        private void Mantenimiento_Aplicaciones_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
