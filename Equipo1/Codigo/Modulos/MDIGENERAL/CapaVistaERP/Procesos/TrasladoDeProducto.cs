using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;

namespace CapaVistaERP.Procesos
{
    public partial class TrasladoDeProducto : Form
    {
        public Controlador ctrl;
        public TrasladoDeProducto()
        {
            InitializeComponent();
            this.ctrl = new Controlador(); 
            this.fillData();
        }
        

        public void fillData()
        {
            this.ctrl.llenarComboProducto(this.cb_NombreProd);
            this.ctrl.llenarComboSucursal(this.cb_OrigenSucursal);
            this.ctrl.llenarComboSucursal(this.cb_destinoSucursal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ctrl.TrasladoProducto(cb_OrigenSucursal.SelectedIndex+1, cb_destinoSucursal.SelectedIndex+1, cb_NombreProd.SelectedIndex+1, Convert.ToInt32(txt_CantidadTraslado.Text));
        }
    }
}
