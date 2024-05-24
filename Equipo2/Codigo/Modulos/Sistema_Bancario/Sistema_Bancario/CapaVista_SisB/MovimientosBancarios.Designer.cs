
namespace CapaVista_SisB
{
    partial class MovimientosBancarios
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_vistaTransacciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_cuentaDebito = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cuentaCredito = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_descripcionTransferencia = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelarTransaccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rtrans = new System.Windows.Forms.Button();
            this.txt_valorTransferencia = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_vistaTransacciones);
            this.groupBox2.Location = new System.Drawing.Point(29, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(716, 257);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista de transacciones";
            // 
            // dgv_vistaTransacciones
            // 
            this.dgv_vistaTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaTransacciones.Location = new System.Drawing.Point(32, 29);
            this.dgv_vistaTransacciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_vistaTransacciones.Name = "dgv_vistaTransacciones";
            this.dgv_vistaTransacciones.RowHeadersWidth = 51;
            this.dgv_vistaTransacciones.RowTemplate.Height = 24;
            this.dgv_vistaTransacciones.Size = new System.Drawing.Size(665, 208);
            this.dgv_vistaTransacciones.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_cuentaDebito);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_cuentaCredito);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.txt_descripcionTransferencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cancelarTransaccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_rtrans);
            this.groupBox1.Controls.Add(this.txt_valorTransferencia);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(716, 299);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar transacciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_cuentaDebito
            // 
            this.cmb_cuentaDebito.FormattingEnabled = true;
            this.cmb_cuentaDebito.Location = new System.Drawing.Point(262, 28);
            this.cmb_cuentaDebito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_cuentaDebito.Name = "cmb_cuentaDebito";
            this.cmb_cuentaDebito.Size = new System.Drawing.Size(153, 21);
            this.cmb_cuentaDebito.TabIndex = 94;
            this.cmb_cuentaDebito.SelectedIndexChanged += new System.EventHandler(this.cmb_cuentaDebito_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Cuenta a acreditar:";
            // 
            // txt_cuentaCredito
            // 
            this.txt_cuentaCredito.Location = new System.Drawing.Point(262, 58);
            this.txt_cuentaCredito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cuentaCredito.Name = "txt_cuentaCredito";
            this.txt_cuentaCredito.Size = new System.Drawing.Size(153, 20);
            this.txt_cuentaCredito.TabIndex = 92;
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(439, 92);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(32, 20);
            this.txt_estado.TabIndex = 14;
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // txt_descripcionTransferencia
            // 
            this.txt_descripcionTransferencia.Location = new System.Drawing.Point(262, 117);
            this.txt_descripcionTransferencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_descripcionTransferencia.Name = "txt_descripcionTransferencia";
            this.txt_descripcionTransferencia.Size = new System.Drawing.Size(153, 69);
            this.txt_descripcionTransferencia.TabIndex = 9;
            this.txt_descripcionTransferencia.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta a debitar:";
            // 
            // btn_cancelarTransaccion
            // 
            this.btn_cancelarTransaccion.Location = new System.Drawing.Point(143, 236);
            this.btn_cancelarTransaccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelarTransaccion.Name = "btn_cancelarTransaccion";
            this.btn_cancelarTransaccion.Size = new System.Drawing.Size(279, 27);
            this.btn_cancelarTransaccion.TabIndex = 13;
            this.btn_cancelarTransaccion.Text = "Cancelar transacción";
            this.btn_cancelarTransaccion.UseVisualStyleBackColor = true;
            this.btn_cancelarTransaccion.Click += new System.EventHandler(this.btn_cancelarTransaccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción: ";
            // 
            // btn_rtrans
            // 
            this.btn_rtrans.Location = new System.Drawing.Point(143, 205);
            this.btn_rtrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rtrans.Name = "btn_rtrans";
            this.btn_rtrans.Size = new System.Drawing.Size(279, 27);
            this.btn_rtrans.TabIndex = 10;
            this.btn_rtrans.Text = "Realizar transacción";
            this.btn_rtrans.UseVisualStyleBackColor = true;
            this.btn_rtrans.Click += new System.EventHandler(this.btn_rtrans_Click);
            // 
            // txt_valorTransferencia
            // 
            this.txt_valorTransferencia.Location = new System.Drawing.Point(262, 89);
            this.txt_valorTransferencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_valorTransferencia.Name = "txt_valorTransferencia";
            this.txt_valorTransferencia.Size = new System.Drawing.Size(153, 20);
            this.txt_valorTransferencia.TabIndex = 6;
            // 
            // MovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovimientosBancarios";
            this.Text = "MovimientosBancarios";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_vistaTransacciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.RichTextBox txt_descripcionTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelarTransaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rtrans;
        private System.Windows.Forms.TextBox txt_valorTransferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cuentaCredito;
        private System.Windows.Forms.ComboBox cmb_cuentaDebito;
    }
}