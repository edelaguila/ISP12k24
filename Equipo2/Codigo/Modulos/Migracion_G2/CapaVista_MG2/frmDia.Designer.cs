
namespace CapaVista_MG2
{
    partial class frmDia
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.panel_enable = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(19, 17);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(38, 25);
            this.lbl_numero.TabIndex = 0;
            this.lbl_numero.Text = "11";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.Location = new System.Drawing.Point(21, 51);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(22, 16);
            this.lbl_dia.TabIndex = 1;
            this.lbl_dia.Text = "11";
            // 
            // panel_enable
            // 
            this.panel_enable.Location = new System.Drawing.Point(24, 70);
            this.panel_enable.Name = "panel_enable";
            this.panel_enable.Size = new System.Drawing.Size(33, 21);
            this.panel_enable.TabIndex = 2;
            // 
            // frmDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_enable);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.lbl_numero);
            this.Name = "frmDia";
            this.Size = new System.Drawing.Size(122, 113);
            this.Click += new System.EventHandler(this.frmDia_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmDia_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_numero;
        public System.Windows.Forms.Label lbl_dia;
        public System.Windows.Forms.Panel panel_enable;
    }
}
