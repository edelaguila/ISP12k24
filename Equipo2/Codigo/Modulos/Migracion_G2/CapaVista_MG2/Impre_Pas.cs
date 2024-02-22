using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MG2;
using System.Drawing.Printing;


namespace CapaVista_MG2
{
    public partial class RV : Form
    {
        private Controlador controlador;
        private DataTable datosTabla;

        public RV()
        {
            InitializeComponent();
            controlador = new Controlador();
            dgv_datos.Visible = false;
            this.Load += RV_Load;
            btn_buscar.Click += btn_buscar_Click;
            btn_generar.Click += btn_generar_Click;
        }

        private void RV_Load(object sender, EventArgs e)
        {
            datosTabla = controlador.llenarTbl("tbl_pruebapasaporte");
            dgv_datos.DataSource = datosTabla;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_correlativo.Text))
            {
                // Buscar la fila correspondiente al correlativo ingresado en el DataTable
                DataRow[] filas = datosTabla.Select($"Pk_id_persona = '{txt_correlativo.Text}'");

                if (filas.Length > 0)
                {
                    // Mostrar los datos en los TextBox correspondientes
                    txt_nombre.Text = filas[0]["nombre_persona"].ToString();
                    txt_dpi.Text = filas[0]["dpi_persona"].ToString();
                    txt_fechaNac.Text = filas[0]["fecha_nacimiento"].ToString();
                    txt_lugarNac.Text = filas[0]["lugar_nacimiento"].ToString();
                    txt_fechaEmi.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    DateTime fechaVencimiento = DateTime.Now.AddYears(2);
                    txt_fechaVenci.Text = fechaVencimiento.ToString("yyyy-MM-dd");
                }
                else
                {
                    // Limpiar los TextBox si no se encontraron datos
                    LimpiarTextBox();
                    MessageBox.Show("No se encontraron datos para el correlativo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Limpiar los TextBox si el correlativo está vacío
                LimpiarTextBox();
                MessageBox.Show("Por favor ingrese un correlativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarTextBox()
        {
            txt_nombre.Text = "";
            txt_dpi.Text = "";
            txt_fechaNac.Text = "";
            txt_lugarNac.Text = "";
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {




            /*//Llamar a Reportes
            Impresion_Pasa formPasaporte = new Impresion_Pasa();
            // Mostrar CrystalReport
            formPasaporte.Show();*/

            //GENERACIÓN CON WINDOWS PRINTER EN CASO DE FALLA
            // Generar el contenido del pasaporte
            string contenidoPasaporte = $"Nombre: {txt_nombre.Text}\nDPI: {txt_dpi.Text}\nFecha de Nacimiento: {txt_fechaNac.Text}\nLugar de Nacimiento: {txt_lugarNac.Text}\nFecha de Emisión: {txt_fechaEmi.Text}\nFecha de Vencimiento: {txt_fechaVenci.Text}";

            // Crear una instancia de PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (Printsender, args) => {
                // Dibujar el contenido del pasaporte en la página de impresión
                args.Graphics.DrawString(contenidoPasaporte, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            };

            // Iniciar el proceso de impresión
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
}