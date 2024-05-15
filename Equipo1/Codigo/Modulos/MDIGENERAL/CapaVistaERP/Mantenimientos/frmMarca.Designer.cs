
namespace CapaVistaERP.Mantenimientos
{
    partial class frmMarca
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Marca = new System.Windows.Forms.DataGridView();
            this.txt_NombreMarca = new System.Windows.Forms.TextBox();
            this.txt_IDMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marca)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(391, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 28);
            this.label6.TabIndex = 44;
            this.label6.Text = "REGISTRO DE MARCA";
            // 
            // dgv_Marca
            // 
            this.dgv_Marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marca.Location = new System.Drawing.Point(12, 325);
            this.dgv_Marca.Name = "dgv_Marca";
            this.dgv_Marca.RowHeadersWidth = 51;
            this.dgv_Marca.RowTemplate.Height = 24;
            this.dgv_Marca.Size = new System.Drawing.Size(1002, 150);
            this.dgv_Marca.TabIndex = 45;
            this.dgv_Marca.Tag = "tbl_marcas";
            // 
            // txt_NombreMarca
            // 
            this.txt_NombreMarca.AcceptsReturn = true;
            this.txt_NombreMarca.Location = new System.Drawing.Point(634, 238);
            this.txt_NombreMarca.Name = "txt_NombreMarca";
            this.txt_NombreMarca.Size = new System.Drawing.Size(174, 22);
            this.txt_NombreMarca.TabIndex = 53;
            this.txt_NombreMarca.Tag = "nombre_marca";
            // 
            // txt_IDMarca
            // 
            this.txt_IDMarca.Location = new System.Drawing.Point(233, 238);
            this.txt_IDMarca.Name = "txt_IDMarca";
            this.txt_IDMarca.Size = new System.Drawing.Size(174, 22);
            this.txt_IDMarca.TabIndex = 52;
            this.txt_IDMarca.Tag = "id_marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(546, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(184, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 25);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 54;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 491);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_NombreMarca);
            this.Controls.Add(this.txt_IDMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Marca);
            this.Controls.Add(this.label6);
            this.Name = "frmMarca";
            this.Text = "frmMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Marca;
        private System.Windows.Forms.TextBox txt_NombreMarca;
        private System.Windows.Forms.TextBox txt_IDMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CapaVista.Navegador navegador1;
    }
}