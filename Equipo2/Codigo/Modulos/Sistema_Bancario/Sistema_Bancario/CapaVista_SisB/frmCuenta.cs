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
using CapaControlador_SisB;
namespace CapaVista_SisB
{
    public partial class frmCuenta : Form
    {
        WidgetHelper helper;
        Seguridad_Controlador.Controlador ctrl;
        public frmCuenta()
        {
            this.helper = new WidgetHelper();
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            //navegador2.config("tbl_cuenta", this);
            this.loadCmbs();
        }

        public void loadCmbs()
        {
            this.helper.fillCliente(this.cmb_cliente);
            this.helper.fillMoneda(this.cmb_moneda);
            this.helper.fillTipoCuenta(this.cmb_tcuenta);
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
