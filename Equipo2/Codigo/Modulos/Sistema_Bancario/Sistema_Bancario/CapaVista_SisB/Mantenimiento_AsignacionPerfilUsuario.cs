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
    public partial class Mantenimiento_AsignacionPerfilUsuario : Form
    {
        public Mantenimiento_AsignacionPerfilUsuario()
        {
            InitializeComponent();
            this.navegador1.config("tbl_asignacionesperfilsusuario", this, "9002");
        }
    }
}
