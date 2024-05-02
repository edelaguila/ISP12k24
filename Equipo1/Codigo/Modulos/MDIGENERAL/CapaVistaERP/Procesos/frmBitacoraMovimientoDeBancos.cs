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
    public partial class frmBitacoraMovimientoDeBancos : Form
    {
        Controlador cn = new Controlador();
        public frmBitacoraMovimientoDeBancos()
        {
            InitializeComponent();
            actualizardatagriew();
            dtTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string emp = "tbl_movimientodebancos";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenartablabitacoraMB(emp);
            dtTabla.DataSource = dt;

        }

        //public void BuscarPorFecha()
        //{
         //   DateTime fechaSeleccionada = dateTimePicker1.Value;
          //  string strfiltro = fechaSeleccionada.ToString("yyyy-MM-dd");
           // DataTable dt = cn.BuscarMB(strfiltro);
            //dtTabla.DataSource = dt;
        //}



        private async void btn_nueva_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);
            frmMovimientoDeBancos form2 = new frmMovimientoDeBancos();
            form2.Show();
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dtTabla.SelectedRows.Count > 0)
            {
                // Obtener el ID de la fila seleccionada
                int idSeleccionado = Convert.ToInt32(dtTabla.SelectedRows[0].Cells["id_movimientoBanco"].Value);

                // Llamar al método EliminarMovimiento del controlador con el ID seleccionado
                bool eliminado = cn.EliminarMovimiento(idSeleccionado);

                if (eliminado)
                {
                    MessageBox.Show("Registro eliminado correctamente.");
                    // Actualizar el DataGridView después de la eliminación
                    actualizardatagriew();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro. Verifique el ID del movimiento.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int añoSeleccionado = Convert.ToInt32(cb_año.SelectedItem);
            DataTable dtRegistros = cn.FiltrarRegistrosPorFecha(añoSeleccionado, "Diario");
            // Asignar el DataTable al DataGridView para mostrar los registros filtrados
            dtTabla.DataSource = dtRegistros;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int añoSeleccionado = Convert.ToInt32(cb_año.SelectedItem);
            DataTable dtRegistros = cn.FiltrarRegistrosPorFecha(añoSeleccionado, "Semanal");
            // Asignar el DataTable al DataGridView para mostrar los registros filtrados
            dtTabla.DataSource = dtRegistros;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int añoSeleccionado = Convert.ToInt32(cb_año.SelectedItem);
            DataTable dtRegistros = cn.FiltrarRegistrosPorFecha(añoSeleccionado, "Mensual");
            // Asignar el DataTable al DataGridView para mostrar los registros filtrados
            dtTabla.DataSource = dtRegistros;
        }
    }
}
