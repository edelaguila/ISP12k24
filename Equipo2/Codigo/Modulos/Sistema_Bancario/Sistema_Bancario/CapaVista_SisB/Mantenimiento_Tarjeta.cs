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
    public partial class Mantenimiento_Tarjeta : Form
    {
        //Codigo de configuracion al navegador
        public Mantenimiento_Tarjeta()
        {
            InitializeComponent();
            navegador1.config("tbl_tarjeta", this, "8003");
        }
    }
}
