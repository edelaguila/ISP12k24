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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            navegador1.config("tbl_cliente", this, "8005");
        }
    }
}
