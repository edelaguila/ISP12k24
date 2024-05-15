
namespace CapaVista_SisB
{
    partial class Mantenimiento_Tipo_Transaccion
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
            this.navegador2 = new Navegador2._0.Navegador();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador2
            // 
            this.navegador2.Location = new System.Drawing.Point(22, 41);
            this.navegador2.Margin = new System.Windows.Forms.Padding(4);
            this.navegador2.Name = "navegador2";
            this.navegador2.Size = new System.Drawing.Size(751, 78);
            this.navegador2.TabIndex = 54;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 58;
            this.textBox3.Tag = "ttr_nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 57;
            this.textBox1.Tag = "ttr_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nombre tipo transaccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id tipo transaccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Operacion tipo transaccion:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 60;
            this.textBox2.Tag = "ttr_operacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 150);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.Tag = "tbl_tipo_transaccion";
            // 
            // Mantenimiento_Tipo_Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador2);
            this.Name = "Mantenimiento_Tipo_Transaccion";
            this.Text = "Mantenimiento_Tipo_Transaccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador2._0.Navegador navegador2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}