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
        private CapaControladorERP.Controlador ctrl;
        public frmMovimientoInventario()
        {
            InitializeComponent();
            ctrl = new CapaControladorERP.Controlador();
            this.navegador1.config("tbl_movimiento_inv", this, "8006");
            this.fill();
        }

        public void fill()
        {
            this.ctrl.llenarComboProducto(cb_Producto);
            this.ctrl.llenarComboSucursal(cb_Sucursal);
            List<string>data = this.ctrl.llenarCombo("nombre_movimiento", "tbl_movimientos");
            foreach(string str in data)
            {
                cb_Movimiento.Items.Add(str);
            }
        }

        private void cb_Movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Movimiento.Text = (cb_Movimiento.SelectedIndex + 1).ToString();
        }

        private void cb_Sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Sucursal.Text = (cb_Sucursal.SelectedIndex + 1).ToString();
        }

        private void cb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Producto.Text = (cb_Producto.SelectedIndex + 1).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmMovimientoInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
