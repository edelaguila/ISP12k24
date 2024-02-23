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
    public partial class Cancelar_Cita : Form
    {
        
        public Cancelar_Cita()
        {
            Seguridad_Controlador.Controlador cont = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("Cita", this);
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
