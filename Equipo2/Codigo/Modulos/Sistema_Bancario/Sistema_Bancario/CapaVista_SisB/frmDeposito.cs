using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_SisB;
using Seguridad_Controlador;
using CapaModelo_SisB.Libraries;
using CapaModelo_SisB.Templates;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace CapaVista_SisB
{
    public partial class frmDeposito : Form
    {
        CapaControlador_SisB.Controlador ctrl = new CapaControlador_SisB.Controlador();
        double monto = 0;
        public frmDeposito()
        {
            InitializeComponent();
        }

        public void Comprobante()
        {
            string folderPath = @"D:\9NO_SEMESTRE\INGENIERIA DE SOFTWARE I\ISP12k24\Equipo2\Codigo\Modulos\Sistema_Bancario\Sistema_Bancario\CapaVista_SisB\Comprobantes";
            string fileName = "Comprobante.pdf";
            string filePath = Path.Combine(folderPath, fileName);

            // Asegúrate de que el directorio existe
            Directory.CreateDirectory(folderPath);

            // Crear el documento PDF
            Document doc = new Document();

            // Crear el FileStream con la ruta específica
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            // Abrir el documento para agregar contenido
            doc.Open();

            // Agregar contenido al documento
            Paragraph paragraph = new Paragraph("Comprobante de Pago")
            {
                Alignment = Element.ALIGN_CENTER
            };
            // Agregar contenido al documento
            doc.Add(paragraph);
            doc.Add(new Paragraph("Deposito a Cuenta: "));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph(txt_cuenta.Text));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Monto: "));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Q " + monto.ToString()));
          

            // Cerrar el documento
            doc.Close();

            Console.WriteLine("PDF creado en: " + filePath);

            OpenPDF(filePath);
        }



        public void fillCmb()
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cuenta_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool result = ctrl.MakeDeposit(txt_cuenta.Text, Convert.ToDouble(textBox1.Text));
            if (result)
            {
                MessageBox.Show("Desposito realizado");
                monto = Convert.ToDouble(textBox1.Text);
                return;
            }
            MessageBox.Show("Cuenta no encontrada, intente de nuevo");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Comprobante();

        }

        private void OpenPDF(string filePath)
        {
            try
            {
                // Verificar si el archivo existe antes de intentar abrirlo
                if (File.Exists(filePath))
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("El archivo no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar abrir el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   