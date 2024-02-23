using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControlador_MG2;
using System.Windows.Forms;

namespace CapaVista_MG2
{
    public partial class Gen_Preguntas : Form
    {
        private Label GP_label1;
        private Label GPlabel12;
        private Label GPlabel3;
        private TextBox GPtextbox2;
        private TextBox GPtextBox3;
        private Label GPlabel11;
        private Button GPbutton;
        private Panel GPpanel1;
        private Controlador controlador;
        private DataGridView dgv_datos;
        private TextBox txt_correlativo;
        private DataTable datosTabla;

        string GP_NOMBRE;
        private Label GP_label_1;
        string GP_LNAC;
        string GP_DPI;

        public Gen_Preguntas()
        {
            InitializeComponent();
            controlador = new Controlador();
            dgv_datos.Visible = false;
            this.Load += RV_Load;

        }
        private void RV_Load(object sender, EventArgs e)
        {
            datosTabla = controlador.llenarTbl("tbl_pruebapasaporte");
            dgv_datos.DataSource = datosTabla;
        }

        private void InitializeComponent()
        {
            this.GPpanel1 = new System.Windows.Forms.Panel();
            this.GP_label1 = new System.Windows.Forms.Label();
            this.GPlabel12 = new System.Windows.Forms.Label();
            this.GPlabel3 = new System.Windows.Forms.Label();
            this.GPtextbox2 = new System.Windows.Forms.TextBox();
            this.GPtextBox3 = new System.Windows.Forms.TextBox();
            this.GPlabel11 = new System.Windows.Forms.Label();
            this.GPbutton = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.txt_correlativo = new System.Windows.Forms.TextBox();
            this.GP_label_1 = new System.Windows.Forms.Label();
            this.GPpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // GPpanel1
            // 
            this.GPpanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPpanel1.Controls.Add(this.GP_label1);
            this.GPpanel1.Location = new System.Drawing.Point(11, 11);
            this.GPpanel1.Margin = new System.Windows.Forms.Padding(2);
            this.GPpanel1.Name = "GPpanel1";
            this.GPpanel1.Size = new System.Drawing.Size(743, 72);
            this.GPpanel1.TabIndex = 46;
            this.GPpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.GPpanel1_Paint);
            // 
            // GP_label1
            // 
            this.GP_label1.AutoSize = true;
            this.GP_label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GP_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GP_label1.Location = new System.Drawing.Point(169, 18);
            this.GP_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GP_label1.Name = "GP_label1";
            this.GP_label1.Size = new System.Drawing.Size(392, 37);
            this.GP_label1.TabIndex = 24;
            this.GP_label1.Text = "Verificacion de Identidad";
            this.GP_label1.Click += new System.EventHandler(this.GP_label1_Click);
            // 
            // GPlabel12
            // 
            this.GPlabel12.AutoSize = true;
            this.GPlabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPlabel12.Location = new System.Drawing.Point(11, 104);
            this.GPlabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPlabel12.Name = "GPlabel12";
            this.GPlabel12.Size = new System.Drawing.Size(752, 17);
            this.GPlabel12.TabIndex = 47;
            this.GPlabel12.Text = "Responda a lo que se le pide correctamente para validar su identidad para la impr" +
    "esion del pasaporte";
            // 
            // GPlabel3
            // 
            this.GPlabel3.AutoSize = true;
            this.GPlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPlabel3.Location = new System.Drawing.Point(11, 173);
            this.GPlabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPlabel3.Name = "GPlabel3";
            this.GPlabel3.Size = new System.Drawing.Size(191, 17);
            this.GPlabel3.TabIndex = 48;
            this.GPlabel3.Text = "Escriba su nombre completo:";
            this.GPlabel3.Click += new System.EventHandler(this.GPlabel3_Click);
            // 
            // GPtextbox2
            // 
            this.GPtextbox2.Location = new System.Drawing.Point(215, 170);
            this.GPtextbox2.Margin = new System.Windows.Forms.Padding(2);
            this.GPtextbox2.Name = "GPtextbox2";
            this.GPtextbox2.Size = new System.Drawing.Size(527, 20);
            this.GPtextbox2.TabIndex = 49;
            this.GPtextbox2.TextChanged += new System.EventHandler(this.GPtextbox2_TextChanged);
            // 
            // GPtextBox3
            // 
            this.GPtextBox3.Location = new System.Drawing.Point(215, 203);
            this.GPtextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.GPtextBox3.Name = "GPtextBox3";
            this.GPtextBox3.Size = new System.Drawing.Size(527, 20);
            this.GPtextBox3.TabIndex = 51;
            this.GPtextBox3.TextChanged += new System.EventHandler(this.GPtextBox3_TextChanged);
            // 
            // GPlabel11
            // 
            this.GPlabel11.AutoSize = true;
            this.GPlabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPlabel11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GPlabel11.Location = new System.Drawing.Point(168, 206);
            this.GPlabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPlabel11.Name = "GPlabel11";
            this.GPlabel11.Size = new System.Drawing.Size(34, 17);
            this.GPlabel11.TabIndex = 52;
            this.GPlabel11.Text = "DPI:";
            this.GPlabel11.Click += new System.EventHandler(this.GPlabel11_Click);
            // 
            // GPbutton
            // 
            this.GPbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.GPbutton.FlatAppearance.BorderSize = 0;
            this.GPbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GPbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPbutton.ForeColor = System.Drawing.Color.White;
            this.GPbutton.Location = new System.Drawing.Point(557, 282);
            this.GPbutton.Name = "GPbutton";
            this.GPbutton.Size = new System.Drawing.Size(185, 37);
            this.GPbutton.TabIndex = 54;
            this.GPbutton.Text = "Siguiente";
            this.GPbutton.UseVisualStyleBackColor = false;
            this.GPbutton.Click += new System.EventHandler(this.GPbutton_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(0, 325);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(240, 150);
            this.dgv_datos.TabIndex = 55;
            // 
            // txt_correlativo
            // 
            this.txt_correlativo.Location = new System.Drawing.Point(215, 135);
            this.txt_correlativo.Name = "txt_correlativo";
            this.txt_correlativo.Size = new System.Drawing.Size(100, 20);
            this.txt_correlativo.TabIndex = 56;
            // 
            // GP_label_1
            // 
            this.GP_label_1.AutoSize = true;
            this.GP_label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GP_label_1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GP_label_1.Location = new System.Drawing.Point(177, 138);
            this.GP_label_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GP_label_1.Name = "GP_label_1";
            this.GP_label_1.Size = new System.Drawing.Size(25, 17);
            this.GP_label_1.TabIndex = 57;
            this.GP_label_1.Text = "ID:";
            this.GP_label_1.Click += new System.EventHandler(this.GP_label_1_Click);
            // 
            // Gen_Preguntas
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 350);
            this.Controls.Add(this.GP_label_1);
            this.Controls.Add(this.txt_correlativo);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.GPbutton);
            this.Controls.Add(this.GPlabel11);
            this.Controls.Add(this.GPtextBox3);
            this.Controls.Add(this.GPtextbox2);
            this.Controls.Add(this.GPlabel3);
            this.Controls.Add(this.GPlabel12);
            this.Controls.Add(this.GPpanel1);
            this.Name = "Gen_Preguntas";
            this.Load += new System.EventHandler(this.Gen_Preguntas_Load);
            this.GPpanel1.ResumeLayout(false);
            this.GPpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Gen_Preguntas_Load(object sender, EventArgs e)
        {

        }
        private void GPbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_correlativo.Text))
            {
                // Buscar la fila correspondiente al correlativo ingresado en el DataTable
                DataRow[] filas = datosTabla.Select($"Pk_id_persona = '{txt_correlativo.Text}'");

                if (filas.Length > 0)
                {
                    // Mostrar los datos en los TextBox correspondientes
                    GP_NOMBRE = filas[0]["nombre_persona"].ToString();
                    GP_DPI = filas[0]["dpi_persona"].ToString();
                    
                }
                else
                {
                    // Limpiar los TextBox si no se encontraron datos
                    //LimpiarTextBox();
                    // MessageBox.Show("No se encontraron datos para el correlativo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Limpiar los TextBox si el correlativo está vacío
                // LimpiarTextBox();
                // MessageBox.Show("Por favor ingrese un correlativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (GPtextbox2.Text == GP_NOMBRE && GPtextBox3.Text == GP_DPI )
            {
                MessageBox.Show("Informacion Correcta", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La Informacion NO coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GP_label1_Click(object sender, EventArgs e)
        {

        }

        private void GPpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GPlabel3_Click(object sender, EventArgs e)
        {

        }

        private void GPtextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GPlabel11_Click(object sender, EventArgs e)
        {

        }

        private void GPtextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void GPlabel5_Click(object sender, EventArgs e)
        {

        }

        private void GP_label_1_Click(object sender, EventArgs e)
        {

        }

        private void BG_textbox_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BG__Click(object sender, EventArgs e)
        {

        }
    }
}

