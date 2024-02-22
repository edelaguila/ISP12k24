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
    public partial class frmDia : UserControl
    {
        public Persona mipersona;
        public CapaControlador_MG2.Controlador ctrl;
        public frmDia()
        {
            this.ctrl = new CapaControlador_MG2.Controlador();
            this.mipersona = new Persona();
            InitializeComponent();
            this.asignEvents();
        }


        public void setData(Persona p)
        {
            this.mipersona = p;
        }

        public void asignEvents()
        {
            this.MouseClick += ClickEvent;
            foreach (Control c in this.Controls)
            {
                c.MouseClick += ClickEvent;
            }
        }

        public void ClickEvent(object sender, MouseEventArgs e)
        {
            this.ctrl.saveCita(this.mipersona);
        }

        private void frmDia_Click(object sender, EventArgs e)
        {
        }

        private void frmDia_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
