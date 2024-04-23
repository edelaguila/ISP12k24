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
    public partial class frmTipoCuenta : Form
    {
        public frmTipoCuenta()
        {
            InitializeComponent();
            this.navegador1.config("tbl_tipo_cuenta", this,"8002");
        }
    }
}
