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
    public partial class OperacionesProvMaestro : Form
    {
        Controlador cn = new Controlador();
        public OperacionesProvMaestro(string idprove, string nombreprov, string nitprove)
        {
            InitializeComponent();

            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ayudas_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"..\..\..\..\..\..\..\Ayuda\Modulos\Ayudas\AyudasByTech.chm";
            Help.ShowHelp(this, rutaAyuda, "OrdenesdeCompra.html");
        }

        private void cb_filtrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*// Obtener el índice de la opción seleccionada
            int seleccion = cb_filtrado.SelectedIndex;
            string tipoFiltro = "";
            int añoSeleccionado = Convert.ToInt32(cb_año.SelectedItem);

            // Ejecutar diferentes acciones según el índice seleccionado
            switch (seleccion)
            {
                case 0:
                    tipoFiltro = "Diario";
                    DataTable dtRegistros = cn.ObtenerOrdenesCompraPorFecha(añoSeleccionado, tipoFiltro);
                    // Asignar el DataTable al DataGridView para mostrar los registros filtrados
                    dg_facturasprove.DataSource = dtRegistros;
                    break;
                case 1:
                    tipoFiltro = "Semanal";
                    DataTable dtRegistros1 = cn.ObtenerOrdenesCompraPorFecha(añoSeleccionado, tipoFiltro);
                    // Asignar el DataTable al DataGridView para mostrar los registros filtrados
                    dg_facturasprove.DataSource = dtRegistros1;
                    break;
                case 2:
                    tipoFiltro = "Mensual";
                    DataTable dtRegistros2 = cn.ObtenerOrdenesCompraPorFecha(añoSeleccionado, tipoFiltro);
                    // Asignar el DataTable al DataGridView para mostrar los registros filtrados
                    dg_facturasprove.DataSource = dtRegistros2;
                    break;
                default:
                    break;
            }
            report.MostrarReporte(tipoFiltro, añoSeleccionado);*/
        }
    }
   
}
