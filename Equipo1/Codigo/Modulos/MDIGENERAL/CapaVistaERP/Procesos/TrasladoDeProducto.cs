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


        private void dgv_traslado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TrasladoDeProducto_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            int index1 = cb_OrigenSucursal.SelectedIndex;
            int index2 = cb_destinoSucursal.SelectedIndex;
            dgv_traslado.Rows.Add(ctrl.getProductId(cb_NombreProd.SelectedIndex), cb_NombreProd.Text, txt_CantidadTraslado.Text, ctrl.getSucursalId(index1), ctrl.getSucursalId(index2));
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (dgv_traslado.SelectedRows.Count > 0 && !dgv_traslado.SelectedRows[0].IsNewRow)
            {
                dgv_traslado.Rows.Remove(dgv_traslado.SelectedRows[0]);
            }
        }

        private void btn_traslado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_traslado.Rows)
            {
                int IdOrigen = Convert.ToInt32(row.Cells[3].Value);
                int IdDestino = Convert.ToInt32(row.Cells[4].Value);
                TrasladoControlador.createTraslado(DateTime.Now.ToString("yyyy-MM-dd"), txt_solicitante.Text, txt_entregador.Text, IdOrigen, IdDestino);
                int Id = Convert.ToInt32(row.Cells[0].Value);
                int Cantidad = Convert.ToInt32(row.Cells[2].Value);
                bool exist = TrasladoControlador.productoExiste(IdDestino, Id);
                int existenciasO = TrasladoControlador.obtenerCantidadExistencias(IdOrigen, Id);
                if (exist)
                {
                    int existenciasD = TrasladoControlador.obtenerCantidadExistencias(IdDestino, Id);
                    TrasladoControlador.actualizarExistencias(IdDestino, Id, Cantidad + existenciasD);
                    TrasladoControlador.actualizarExistencias(IdOrigen, Id, existenciasO - Cantidad);
                }
                else
                {
                    TrasladoControlador.crearExistencia(IdDestino, Id, Cantidad);
                    TrasladoControlador.actualizarExistencias(IdOrigen, Id, existenciasO - Cantidad);
                }
            }
            MessageBox.Show("¡Traslado realizado con éxito!");
        }

        public void limpiar()
        {
            cb_NombreProd.Text = "";
            txt_CantidadTraslado.Text = "";
        }
    }
}
