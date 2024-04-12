
namespace CapaVista_SisB
{
    partial class frmHistorial
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
            this.FHlabel1 = new System.Windows.Forms.Label();
            this.FHlabel2 = new System.Windows.Forms.Label();
            this.FHlabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FHbutton1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FHcomboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FHlabel1
            // 
            this.FHlabel1.AutoSize = true;
            this.FHlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHlabel1.Location = new System.Drawing.Point(82, 23);
            this.FHlabel1.Name = "FHlabel1";
            this.FHlabel1.Size = new System.Drawing.Size(511, 44);
            this.FHlabel1.TabIndex = 1;
            this.FHlabel1.Text = "Historial de Transacciones";
            // 
            // FHlabel2
            // 
            this.FHlabel2.AutoSize = true;
            this.FHlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHlabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.FHlabel2.Location = new System.Drawing.Point(25, 94);
            this.FHlabel2.Name = "FHlabel2";
            this.FHlabel2.Size = new System.Drawing.Size(200, 25);
            this.FHlabel2.TabIndex = 3;
            this.FHlabel2.Text = "Numero de cuenta: ";
            // 
            // FHlabel3
            // 
            this.FHlabel3.AutoSize = true;
            this.FHlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHlabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.FHlabel3.Location = new System.Drawing.Point(391, 94);
            this.FHlabel3.Name = "FHlabel3";
            this.FHlabel3.Size = new System.Drawing.Size(65, 25);
            this.FHlabel3.TabIndex = 4;
            this.FHlabel3.Text = "Mes: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(25, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Transaccion: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 245);
            this.dataGridView1.TabIndex = 6;
            // 
            // FHbutton1
            // 
            this.FHbutton1.Location = new System.Drawing.Point(594, 374);
            this.FHbutton1.Name = "FHbutton1";
            this.FHbutton1.Size = new System.Drawing.Size(75, 23);
            this.FHbutton1.TabIndex = 7;
            this.FHbutton1.Text = "Buscar";
            this.FHbutton1.UseVisualStyleBackColor = true;
            // 
            // FHcomboBox1
            // 
            this.FHcomboBox1.FormattingEnabled = true;
            this.FHcomboBox1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre ",
            "Octubre ",
            "Noviembre ",
            "Diciembre "});
            this.FHcomboBox1.Location = new System.Drawing.Point(450, 95);
            this.FHcomboBox1.Name = "FHcomboBox1";
            this.FHcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.FHcomboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(346, 20);
            this.textBox2.TabIndex = 10;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FHcomboBox1);
            this.Controls.Add(this.FHbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FHlabel3);
            this.Controls.Add(this.FHlabel2);
            this.Controls.Add(this.FHlabel1);
            this.Name = "frmHistorial";
            this.Text = "frmHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FHlabel1;
        private System.Windows.Forms.Label FHlabel2;
        private System.Windows.Forms.Label FHlabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FHbutton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox FHcomboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}