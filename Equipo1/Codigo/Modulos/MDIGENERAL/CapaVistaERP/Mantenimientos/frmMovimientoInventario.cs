using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frmMovimientoInventario : Form
    {
        public frmMovimientoInventario()
        {
            InitializeComponent();
            this.navegador1.config("tbl_movimiento_inv", this, "");
            this.navegador1._initSeguridad();
        }
    }
}
