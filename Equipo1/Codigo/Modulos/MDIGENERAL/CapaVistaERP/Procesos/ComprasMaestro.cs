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

//Programado por: Carol Chuy
namespace CapaVistaERP.Procesos
{
    public partial class ComprasMaestro : Form
    {
        private ComprasEli ComprasEli;
        private ComprasModi ComprasModi;
        private string idord = "";
        private string fechaS = "";
        private string fechaE = "";
        private string solicitante = "";
        private string proveedor = "";
        Controlador cn = new Controlador();
        public ComprasMaestro(ComprasEli comprasEli, ComprasModi comprasModi)
        {
            InitializeComponent();
            actualizardatagridview();
            ComprasEli = comprasEli;
            ComprasModi = comprasModi;
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            Compras Compras = new Compras(idord, fechaS, fechaE, solicitante, proveedor);
            Compras.Show();
        }
        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTablas("tbl_compras");
            dt_datos.DataSource = dt;
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice de la opción seleccionada
            int seleccion = cb_filtro.SelectedIndex;

            // Ejecutar diferentes acciones según el índice seleccionado
            switch (seleccion)
            {
                case 0:
                    int añoSeleccionado = Convert.ToInt32(cb_año.SelectedItem);
                    DataTable dtRegistros = cn.ObtenerComprasPorFecha(añoSeleccionado, "Diario");
                    // Asignar el DataTable al DataGridView para mostrar los registros filtrados
                    dt_datos.DataSource = dtRegistros;
                    break;
                case 1:
                    int añoSeleccionado1 = Convert.ToInt32(cb_año.SelectedItem);
                    DataTable dtRegistros1 = cn.ObtenerComprasPorFecha(añoSeleccionado1, "Semanal");
                    // Asignar el DataTable al DataGridView para mostrar los registros filtrados
                    dt_datos.DataSource = dtRegistros1;
                    break;
                case 2:
                    int añoSeleccionado2 = Convert.ToInt32(cb_año.SelectedItem);
                    DataTable dtRegistros2 = cn.ObtenerComprasPorFecha(añoSeleccionado2, "Mensual");
                    // Asignar el DataTable al DataGridView para mostrar los registros filtrados
                    dt_datos.DataSource = dtRegistros2;
                    break;
                default:
                    break;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dt_datos.SelectedRows.Count > 0)
            {
                // Obtener la primera celda de la fila seleccionada (que corresponde a la primera columna)
                DataGridViewCell firstCell = dt_datos.SelectedRows[0].Cells[0];
                string valorPrimeraColumna = firstCell.Value.ToString();
                ComprasEli.RecibirDatosDesdeComprasEli(valorPrimeraColumna);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Selección de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dt_datos.SelectedRows.Count > 0)
            {
                // Obtener la primera celda de la fila seleccionada (que corresponde a la primera columna)
                DataGridViewCell firstCell = dt_datos.SelectedRows[0].Cells[0];
                string valorPrimeraColumna = firstCell.Value.ToString();
                ComprasModi.RecibirDatosDesdeCompraModi(valorPrimeraColumna);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Selcción Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
