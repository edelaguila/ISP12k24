
namespace Vista_PrototipoMenu
{
    partial class frmGeneracionBoleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneracionBoleta));
            this.button2 = new System.Windows.Forms.Button();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_añosDuracion = new System.Windows.Forms.TextBox();
            this.txt_precioQuetzal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tasaPromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_precioDolar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_pasaporte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tipoPago = new System.Windows.Forms.TextBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.cb_dpi = new System.Windows.Forms.ComboBox();
            this.txt_pasaporteSeleccionado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_identificadorDPI = new System.Windows.Forms.TextBox();
            this.btn_BusquedaDPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 31);
            this.button2.TabIndex = 67;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_edad
            // 
            this.txt_edad.Enabled = false;
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(357, 530);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(91, 28);
            this.txt_edad.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Edad";
            // 
            // txt_genero
            // 
            this.txt_genero.Enabled = false;
            this.txt_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genero.Location = new System.Drawing.Point(500, 530);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(135, 28);
            this.txt_genero.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 63;
            this.label10.Text = "Genero";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(19, 530);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(302, 28);
            this.txt_nombre.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 61;
            this.label9.Text = "Nombre completo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ingrese DPI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "años de duracion";
            // 
            // txt_añosDuracion
            // 
            this.txt_añosDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_añosDuracion.Location = new System.Drawing.Point(19, 347);
            this.txt_añosDuracion.Name = "txt_añosDuracion";
            this.txt_añosDuracion.Size = new System.Drawing.Size(138, 28);
            this.txt_añosDuracion.TabIndex = 56;
            // 
            // txt_precioQuetzal
            // 
            this.txt_precioQuetzal.Enabled = false;
            this.txt_precioQuetzal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioQuetzal.Location = new System.Drawing.Point(457, 272);
            this.txt_precioQuetzal.Name = "txt_precioQuetzal";
            this.txt_precioQuetzal.Size = new System.Drawing.Size(135, 28);
            this.txt_precioQuetzal.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Precio en Q";
            // 
            // txt_tasaPromedio
            // 
            this.txt_tasaPromedio.Enabled = false;
            this.txt_tasaPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tasaPromedio.Location = new System.Drawing.Point(19, 272);
            this.txt_tasaPromedio.Name = "txt_tasaPromedio";
            this.txt_tasaPromedio.Size = new System.Drawing.Size(166, 28);
            this.txt_tasaPromedio.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tasa  promedio";
            // 
            // txt_precioDolar
            // 
            this.txt_precioDolar.Enabled = false;
            this.txt_precioDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioDolar.Location = new System.Drawing.Point(270, 272);
            this.txt_precioDolar.Name = "txt_precioDolar";
            this.txt_precioDolar.Size = new System.Drawing.Size(135, 28);
            this.txt_precioDolar.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Precio en $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Codido del pasaporte";
            // 
            // cb_pasaporte
            // 
            this.cb_pasaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pasaporte.FormattingEnabled = true;
            this.cb_pasaporte.Location = new System.Drawing.Point(19, 185);
            this.cb_pasaporte.Name = "cb_pasaporte";
            this.cb_pasaporte.Size = new System.Drawing.Size(166, 30);
            this.cb_pasaporte.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tipo de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Concepto:";
            // 
            // txt_tipoPago
            // 
            this.txt_tipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoPago.Location = new System.Drawing.Point(500, 59);
            this.txt_tipoPago.Name = "txt_tipoPago";
            this.txt_tipoPago.Size = new System.Drawing.Size(135, 28);
            this.txt_tipoPago.TabIndex = 71;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_concepto.Location = new System.Drawing.Point(15, 59);
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(254, 62);
            this.txt_concepto.TabIndex = 72;
            // 
            // cb_dpi
            // 
            this.cb_dpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dpi.FormattingEnabled = true;
            this.cb_dpi.Location = new System.Drawing.Point(19, 464);
            this.cb_dpi.Name = "cb_dpi";
            this.cb_dpi.Size = new System.Drawing.Size(235, 30);
            this.cb_dpi.TabIndex = 73;
            // 
            // txt_pasaporteSeleccionado
            // 
            this.txt_pasaporteSeleccionado.Enabled = false;
            this.txt_pasaporteSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pasaporteSeleccionado.ForeColor = System.Drawing.Color.Black;
            this.txt_pasaporteSeleccionado.Location = new System.Drawing.Point(270, 185);
            this.txt_pasaporteSeleccionado.Name = "txt_pasaporteSeleccionado";
            this.txt_pasaporteSeleccionado.Size = new System.Drawing.Size(179, 28);
            this.txt_pasaporteSeleccionado.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(267, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 17);
            this.label12.TabIndex = 74;
            this.label12.Text = "Pasaporte seleccionado";
            // 
            // txt_identificadorDPI
            // 
            this.txt_identificadorDPI.Enabled = false;
            this.txt_identificadorDPI.Location = new System.Drawing.Point(371, 464);
            this.txt_identificadorDPI.Name = "txt_identificadorDPI";
            this.txt_identificadorDPI.Size = new System.Drawing.Size(91, 22);
            this.txt_identificadorDPI.TabIndex = 76;
            // 
            // btn_BusquedaDPI
            // 
            this.btn_BusquedaDPI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BusquedaDPI.BackgroundImage")));
            this.btn_BusquedaDPI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BusquedaDPI.Location = new System.Drawing.Point(288, 452);
            this.btn_BusquedaDPI.Name = "btn_BusquedaDPI";
            this.btn_BusquedaDPI.Size = new System.Drawing.Size(50, 47);
            this.btn_BusquedaDPI.TabIndex = 77;
            this.btn_BusquedaDPI.UseVisualStyleBackColor = true;
            this.btn_BusquedaDPI.Click += new System.EventHandler(this.btn_BusquedaDPI_Click);
            // 
            // frmGeneracionBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 686);
            this.Controls.Add(this.btn_BusquedaDPI);
            this.Controls.Add(this.txt_identificadorDPI);
            this.Controls.Add(this.txt_pasaporteSeleccionado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_dpi);
            this.Controls.Add(this.txt_concepto);
            this.Controls.Add(this.txt_tipoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_genero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_añosDuracion);
            this.Controls.Add(this.txt_precioQuetzal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tasaPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_precioDolar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_pasaporte);
            this.Name = "frmGeneracionBoleta";
            this.Text = "frmGeneracionBoleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_añosDuracion;
        private System.Windows.Forms.TextBox txt_precioQuetzal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tasaPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_precioDolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pasaporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tipoPago;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.ComboBox cb_dpi;
        private System.Windows.Forms.TextBox txt_pasaporteSeleccionado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_identificadorDPI;
        private System.Windows.Forms.Button btn_BusquedaDPI;
    }
}