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
        int i = 1;
        int posicion;
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

        public void limpiar()
        {
            cb_NombreProd.Text = "";
            txt_CantidadTraslado.Text = "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombreProd;
            double cantTraslado;

            nombreProd = cb_NombreProd.Text;
            cantTraslado = Convert.ToInt32(txt_CantidadTraslado.Text);

            dgv_traslado.Rows.Add(i+"", nombreProd, cantTraslado);
            i = i + 1;
            limpiar();
            cb_NombreProd.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dgv_traslado.Rows.RemoveAt(posicion);
            cb_NombreProd.Focus();
        }

        private void dgv_traslado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgv_traslado.CurrentRow.Index;
            cb_NombreProd.Text = dgv_traslado[1, posicion].Value.ToString();
            txt_CantidadTraslado.Text = dgv_traslado[2, posicion].Value.ToString();

            btn_eliminar.Enabled = true;
            btn_agregar.Enabled = false;

            cb_NombreProd.Focus();
        }
    }
}
