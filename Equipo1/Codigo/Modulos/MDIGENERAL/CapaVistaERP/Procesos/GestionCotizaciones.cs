using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Procesos
{
    public partial class GestionCotizaciones : Form
    {
        public CapaControladorERP.Controlador ctrl;
        public GestionCotizaciones()
        {
            InitializeComponent();
            this.ctrl = new CapaControladorERP.Controlador();
            this.fillData();
        }

        public void fillData()
        {
            this.data_cotizaciones.DataSource = this.ctrl.ObtenerCotizaciones();
        }

        public void updateProductTable(int Id)
        {
            this.data_products.DataSource = this.ctrl.ObtenerProductosPorCotizacion(Id);
        }

        private void data_cotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_cotizaciones_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (data_cotizaciones.Rows.Count <= 0 ) return;
            int Selected = Convert.ToInt32(data_cotizaciones.SelectedRows[0].Cells[0].Value);
            if (Selected > 0 && Selected != null)
            {
                this.updateProductTable(Selected);
            }
            */
        }

        private void data_cotizaciones_DoubleClick(object sender, EventArgs e)
        {
        }

        private void data_cotizaciones_Click(object sender, EventArgs e)
        {
            int Selected = Convert.ToInt32(data_cotizaciones.SelectedRows[0].Cells[0].Value);
            this.updateProductTable(Selected);
        }
    }
}
