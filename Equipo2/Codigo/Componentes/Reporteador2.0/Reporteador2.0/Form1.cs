using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace Reporteador2._0
{
    public partial class Form1 : Form
    {
        public string table;
        public Form1(string table)
        {
            InitializeComponent();
            this.table = table;
        }

        public void generateReport()
        {
            Sentence sn = new Sentence();
            DataTable dt = sn.getTable(this.table);
            ReportDocument report = new ReportDocument();
            try
            {
                report.SetDataSource(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error cargando tabla");
                Console.WriteLine(e.Message);
            }

            string reportFileName = "informe.rpt"; // Nombre del archivo de informe
            string reportFilePath = Path.Combine(Environment.CurrentDirectory, reportFileName); // Ruta completa del archivo de informe

            try
            {
                using (MemoryStream memoryStream = (MemoryStream)report.ExportToStream(CrystalDecisions.Shared.ExportFormatType.CrystalReport))
                {
                    using (FileStream fileStream = new FileStream(reportFilePath, FileMode.Create))
                    {
                        memoryStream.CopyTo(fileStream);
                    }
                }
                MessageBox.Show("Informe guardado exitosamente en: " + reportFilePath, "Informe generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                report.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.generateReport();
        }
    }
}
