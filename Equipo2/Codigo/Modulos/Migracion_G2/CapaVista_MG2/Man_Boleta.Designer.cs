
namespace CapaVista_MG2
{
    partial class GP
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
            this.tbl_boleta = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_noboleta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_boleta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_boleta
            // 
            this.tbl_boleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_boleta.Location = new System.Drawing.Point(155, 263);
            this.tbl_boleta.Margin = new System.Windows.Forms.Padding(2);
            this.tbl_boleta.Name = "tbl_boleta";
            this.tbl_boleta.RowHeadersWidth = 51;
            this.tbl_boleta.RowTemplate.Height = 24;
            this.tbl_boleta.Size = new System.Drawing.Size(515, 187);
            this.tbl_boleta.TabIndex = 5;
            this.tbl_boleta.Tag = "tbl_boleta";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(277, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 34);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Mantenimiento Boleta";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_noboleta
            // 
            this.lbl_noboleta.AutoSize = true;
            this.lbl_noboleta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noboleta.Location = new System.Drawing.Point(38, 194);
            this.lbl_noboleta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_noboleta.Name = "lbl_noboleta";
            this.lbl_noboleta.Size = new System.Drawing.Size(90, 21);
            this.lbl_noboleta.TabIndex = 11;
            this.lbl_noboleta.Text = "No. Boleta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Correlativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Estado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.Tag = "bol_id";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Tag = "bol_correlativo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(625, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 30;
            this.textBox4.Tag = "bol_id_banco";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(42, 71);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(751, 78);
            this.navegador1.TabIndex = 31;
            // 
            // GP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 507);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_noboleta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbl_boleta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GP";
            this.Tag = "1000";
            this.Text = "GP";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_boleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tbl_boleta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_noboleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private CapaVista.Navegador navegador1;
    }
}