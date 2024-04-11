
namespace CapaVista_SisB
{
    partial class MantenimientoTransaccion
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
            this.txt_valorTrans = new System.Windows.Forms.TextBox();
            this.cb_tipoMov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_transaccionex = new System.Windows.Forms.ComboBox();
            this.txt_transexiten = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tipoMov = new System.Windows.Forms.DataGridView();
            this.txt_idtras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoMov)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.navegador1.Location = new System.Drawing.Point(35, 26);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 0;
            // 
            // txt_valorTrans
            // 
            this.txt_valorTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_valorTrans.Enabled = false;
            this.txt_valorTrans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTrans.Location = new System.Drawing.Point(555, 272);
            this.txt_valorTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valorTrans.Name = "txt_valorTrans";
            this.txt_valorTrans.ReadOnly = true;
            this.txt_valorTrans.Size = new System.Drawing.Size(35, 26);
            this.txt_valorTrans.TabIndex = 115;
            this.txt_valorTrans.Tag = "movtm_valor_transaccion";
            // 
            // cb_tipoMov
            // 
            this.cb_tipoMov.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoMov.FormattingEnabled = true;
            this.cb_tipoMov.Items.AddRange(new object[] {
            "Activo",
            "Pasivo"});
            this.cb_tipoMov.Location = new System.Drawing.Point(341, 272);
            this.cb_tipoMov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_tipoMov.Name = "cb_tipoMov";
            this.cb_tipoMov.Size = new System.Drawing.Size(199, 28);
            this.cb_tipoMov.TabIndex = 114;
            this.cb_tipoMov.SelectedIndexChanged += new System.EventHandler(this.cb_tipoMov_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "Tipo de movimiento:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Escriba transacción si no existe:";
            // 
            // cb_transaccionex
            // 
            this.cb_transaccionex.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_transaccionex.FormattingEnabled = true;
            this.cb_transaccionex.Location = new System.Drawing.Point(341, 207);
            this.cb_transaccionex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_transaccionex.Name = "cb_transaccionex";
            this.cb_transaccionex.Size = new System.Drawing.Size(199, 28);
            this.cb_transaccionex.TabIndex = 111;
            // 
            // txt_transexiten
            // 
            this.txt_transexiten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_transexiten.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transexiten.Location = new System.Drawing.Point(341, 241);
            this.txt_transexiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_transexiten.Name = "txt_transexiten";
            this.txt_transexiten.Size = new System.Drawing.Size(199, 26);
            this.txt_transexiten.TabIndex = 110;
            this.txt_transexiten.Tag = "movtm_transacciones_existentes";
            // 
            // txt_estado
            // 
            this.txt_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_estado.Enabled = false;
            this.txt_estado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(555, 160);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(35, 26);
            this.txt_estado.TabIndex = 109;
            this.txt_estado.Tag = "movtm_status";
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "ID de transacción:";
            // 
            // dgv_tipoMov
            // 
            this.dgv_tipoMov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tipoMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoMov.GridColor = System.Drawing.Color.White;
            this.dgv_tipoMov.Location = new System.Drawing.Point(67, 334);
            this.dgv_tipoMov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tipoMov.Name = "dgv_tipoMov";
            this.dgv_tipoMov.RowHeadersWidth = 51;
            this.dgv_tipoMov.RowTemplate.Height = 24;
            this.dgv_tipoMov.Size = new System.Drawing.Size(927, 231);
            this.dgv_tipoMov.TabIndex = 108;
            this.dgv_tipoMov.Tag = "tbl_mantenimientos_tipo_movimiento";
            // 
            // txt_idtras
            // 
            this.txt_idtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idtras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idtras.Location = new System.Drawing.Point(341, 160);
            this.txt_idtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idtras.Name = "txt_idtras";
            this.txt_idtras.Size = new System.Drawing.Size(199, 26);
            this.txt_idtras.TabIndex = 106;
            this.txt_idtras.Tag = "pk_movtm_id_transaccion";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "Transacciones existentes:";
            // 
            // MantenimientoTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 615);
            this.Controls.Add(this.txt_valorTrans);
            this.Controls.Add(this.cb_tipoMov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_transaccionex);
            this.Controls.Add(this.txt_transexiten);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_tipoMov);
            this.Controls.Add(this.txt_idtras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.navegador1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MantenimientoTransaccion";
            this.Text = "MantenimientoTransaccion";
            this.Load += new System.EventHandler(this.MantenimientoTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_valorTrans;
        private System.Windows.Forms.ComboBox cb_tipoMov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_transaccionex;
        private System.Windows.Forms.TextBox txt_transexiten;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tipoMov;
        private System.Windows.Forms.TextBox txt_idtras;
        private System.Windows.Forms.Label label4;
    }
}