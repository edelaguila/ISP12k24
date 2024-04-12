
namespace CapaVistaERP.Mantenimientos
{
    partial class frmMantenimientoMovimientoConcepto
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
            this.navegador1 = new CapaVista.Navegador();
            this.txt_efecto = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_efecto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(13, 21);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 31;
            // 
            // txt_efecto
            // 
            this.txt_efecto.Enabled = false;
            this.txt_efecto.Location = new System.Drawing.Point(886, 214);
            this.txt_efecto.Name = "txt_efecto";
            this.txt_efecto.Size = new System.Drawing.Size(81, 22);
            this.txt_efecto.TabIndex = 43;
            this.txt_efecto.Tag = "efecto_movimientoBanco";
            this.txt_efecto.Visible = false;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "[seleccionar]",
            "Activo",
            "Suspendido",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(469, 268);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(237, 24);
            this.cb_estado.TabIndex = 42;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // cb_efecto
            // 
            this.cb_efecto.FormattingEnabled = true;
            this.cb_efecto.Items.AddRange(new object[] {
            "[seleccionar]",
            "+",
            "-"});
            this.cb_efecto.Location = new System.Drawing.Point(469, 214);
            this.cb_efecto.Name = "cb_efecto";
            this.cb_efecto.Size = new System.Drawing.Size(237, 24);
            this.cb_efecto.TabIndex = 41;
            this.cb_efecto.SelectedIndexChanged += new System.EventHandler(this.cb_efecto_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 208);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.Tag = "tbl_conceptomovimientodebancos";
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(886, 268);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(81, 22);
            this.txt_estado.TabIndex = 39;
            this.txt_estado.Tag = "estado_movimientoBanco";
            this.txt_estado.Visible = false;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(469, 164);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(237, 22);
            this.txt_concepto.TabIndex = 38;
            this.txt_concepto.Tag = "concepto_movimientoBanco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Estado del movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Efecto del movimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Concepto del movimiento";
            // 
            // frmMantenimientoMovimientoConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 576);
            this.Controls.Add(this.txt_efecto);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.cb_efecto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_concepto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMantenimientoMovimientoConcepto";
            this.Text = "frmMantenimientoMovimientoConcepto";
            this.Load += new System.EventHandler(this.frmMantenimientoMovimientoConcepto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_efecto;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_efecto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}