
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
            this.txt_noboleta = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            this.bol_correlativo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bol_id_banco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_boleta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_boleta
            // 
            this.tbl_boleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_boleta.Location = new System.Drawing.Point(265, 261);
            this.tbl_boleta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbl_boleta.Name = "tbl_boleta";
            this.tbl_boleta.RowHeadersWidth = 51;
            this.tbl_boleta.RowTemplate.Height = 24;
            this.tbl_boleta.Size = new System.Drawing.Size(271, 187);
            this.tbl_boleta.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(265, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // txt_noboleta
            // 
            this.txt_noboleta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noboleta.Location = new System.Drawing.Point(132, 191);
            this.txt_noboleta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_noboleta.Name = "txt_noboleta";
            this.txt_noboleta.Size = new System.Drawing.Size(124, 27);
            this.txt_noboleta.TabIndex = 12;
            this.txt_noboleta.Tag = "bol_id";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(32, 61);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(751, 78);
            this.navegador1.TabIndex = 24;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // bol_correlativo
            // 
            this.bol_correlativo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bol_correlativo.Location = new System.Drawing.Point(393, 191);
            this.bol_correlativo.Margin = new System.Windows.Forms.Padding(2);
            this.bol_correlativo.Name = "bol_correlativo";
            this.bol_correlativo.Size = new System.Drawing.Size(124, 27);
            this.bol_correlativo.TabIndex = 26;
            this.bol_correlativo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 194);
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
            // bol_id_banco
            // 
            this.bol_id_banco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bol_id_banco.Location = new System.Drawing.Point(624, 191);
            this.bol_id_banco.Margin = new System.Windows.Forms.Padding(2);
            this.bol_id_banco.Name = "bol_id_banco";
            this.bol_id_banco.Size = new System.Drawing.Size(124, 27);
            this.bol_id_banco.TabIndex = 28;
            // 
            // GP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 507);
            this.Controls.Add(this.bol_id_banco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bol_correlativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_noboleta);
            this.Controls.Add(this.lbl_noboleta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbl_boleta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txt_noboleta;
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.TextBox bol_correlativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bol_id_banco;
    }
}