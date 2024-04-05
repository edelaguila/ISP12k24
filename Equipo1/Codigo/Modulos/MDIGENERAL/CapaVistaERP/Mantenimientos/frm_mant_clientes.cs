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
    public partial class frm_mant_clientes : Form
    {
        public frm_mant_clientes()
        {
            InitializeComponent();
            this.navegador1.config("tbl_clientes", this, "");
        }
    }
}
