using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_SisB;

namespace CapaVista_SisB
{
    public partial class frmDeposito : Form
    {
        CapaControlador_SisB.WidgetHelper whelper;
        public frmDeposito()
        {
            InitializeComponent();
            this.whelper = new WidgetHelper();
            this._init();
        }

        public void _init()
        {
            this.whelper.ComboFiller(cmb_moneda, "tbl_moneda");
        }
    }
}
