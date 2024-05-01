
namespace CapaVistaERP.Mantenimientos
{
    partial class frmLinea
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDLinea = new System.Windows.Forms.TextBox();
            this.txt_NombreLinea = new System.Windows.Forms.TextBox();
            this.dgv_Linea = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Linea)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(381, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "REGISTRO DE LÍNEA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre:";
            // 
            // txt_IDLinea
            // 
            this.txt_IDLinea.Location = new System.Drawing.Point(244, 253);
            this.txt_IDLinea.Name = "txt_IDLinea";
            this.txt_IDLinea.Size = new System.Drawing.Size(174, 22);
            this.txt_IDLinea.TabIndex = 48;
            this.txt_IDLinea.Tag = "id_linea";
            // 
            // txt_NombreLinea
            // 
            this.txt_NombreLinea.Location = new System.Drawing.Point(645, 253);
            this.txt_NombreLinea.Name = "txt_NombreLinea";
            this.txt_NombreLinea.Size = new System.Drawing.Size(174, 22);
            this.txt_NombreLinea.TabIndex = 49;
            this.txt_NombreLinea.Tag = "nombre_linea";
            // 
            // dgv_Linea
            // 
            this.dgv_Linea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Linea.Location = new System.Drawing.Point(12, 340);
            this.dgv_Linea.Name = "dgv_Linea";
            this.dgv_Linea.RowHeadersWidth = 51;
            this.dgv_Linea.RowTemplate.Height = 24;
            this.dgv_Linea.Size = new System.Drawing.Size(999, 150);
            this.dgv_Linea.TabIndex = 50;
            this.dgv_Linea.Tag = "tbl_lineas";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(13, 31);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 51;
            // 
            // frmLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 502);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgv_Linea);
            this.Controls.Add(this.txt_NombreLinea);
            this.Controls.Add(this.txt_IDLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "frmLinea";
            this.Text = "frmLinea";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Linea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDLinea;
        private System.Windows.Forms.TextBox txt_NombreLinea;
        private System.Windows.Forms.DataGridView dgv_Linea;
        private CapaVista.Navegador navegador1;
    }
}