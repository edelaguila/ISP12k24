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
    public partial class GBP : Form
    {
        private Controlador controlador;
        private DataTable datosTabla;
        public CapaControlador_MG2.Controlador ctrl;
        public GBP()
        {
            InitializeComponent();
            this.ctrl = new CapaControlador_MG2.Controlador();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.ctrl.saveBol();
            MessageBox.Show("Pago realizado con exito");
            btn_imprimir.Visible= true;
      
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            List<string> datos = this.ctrl.consultBol();
            string contenidoPasaporte = $"Numero de documento: {datos[0]}\nCorrelativo: {datos[1]}\n Total pagado: Q100.00";

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
