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
    public partial class Mantenimiento_Tipo_Tarjeta : Form
    {
        public Mantenimiento_Tipo_Tarjeta()
        {
            InitializeComponent();
            navegador2.config("tbl_tipo_tarjeta", this, "8005");
        }
    }
}
