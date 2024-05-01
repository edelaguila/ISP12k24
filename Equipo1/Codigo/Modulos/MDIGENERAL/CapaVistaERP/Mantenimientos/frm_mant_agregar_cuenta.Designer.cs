
namespace CapaVistaERP.Mantenimientos
{
    partial class frm_mant_agregar_cuenta
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
            this.txt_tipocuenta = new System.Windows.Forms.TextBox();
            this.txt_sect_banco = new System.Windows.Forms.TextBox();
            this.cb_Banco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tipocuenta = new System.Windows.Forms.ComboBox();
            this.cb_tipoMoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.dgv_agCuentas = new System.Windows.Forms.DataGridView();
            this.txt_tipo_moneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tipo_mon = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tipocuenta
            // 
            this.txt_tipocuenta.Enabled = false;
            this.txt_tipocuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipocuenta.Location = new System.Drawing.Point(823, 164);
            this.txt_tipocuenta.Name = "txt_tipocuenta";
            this.txt_tipocuenta.ReadOnly = true;
            this.txt_tipocuenta.Size = new System.Drawing.Size(114, 26);
            this.txt_tipocuenta.TabIndex = 195;
            this.txt_tipocuenta.Tag = "manac_tipo_de_cuenta";
            this.txt_tipocuenta.Visible = false;
            // 
            // txt_sect_banco
            // 
            this.txt_sect_banco.Enabled = false;
            this.txt_sect_banco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sect_banco.Location = new System.Drawing.Point(459, 313);
            this.txt_sect_banco.Name = "txt_sect_banco";
            this.txt_sect_banco.ReadOnly = true;
            this.txt_sect_banco.Size = new System.Drawing.Size(169, 26);
            this.txt_sect_banco.TabIndex = 194;
            this.txt_sect_banco.Tag = "fk_manac_selec_banco";
            this.txt_sect_banco.Visible = false;
            // 
            // cb_Banco
            // 
            this.cb_Banco.FormattingEnabled = true;
            this.cb_Banco.Location = new System.Drawing.Point(222, 316);
            this.cb_Banco.Name = "cb_Banco";
            this.cb_Banco.Size = new System.Drawing.Size(218, 24);
            this.cb_Banco.TabIndex = 193;
            this.cb_Banco.Tag = "";
            this.cb_Banco.SelectedIndexChanged += new System.EventHandler(this.cb_Banco_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 192;
            this.label4.Text = "Escriba Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 191;
            this.label3.Text = "Alias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 190;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // cb_tipocuenta
            // 
            this.cb_tipocuenta.FormattingEnabled = true;
            this.cb_tipocuenta.Location = new System.Drawing.Point(633, 166);
            this.cb_tipocuenta.Name = "cb_tipocuenta";
            this.cb_tipocuenta.Size = new System.Drawing.Size(184, 24);
            this.cb_tipocuenta.TabIndex = 189;
            this.cb_tipocuenta.SelectedIndexChanged += new System.EventHandler(this.cb_tipocuenta_SelectedIndexChanged);
            // 
            // cb_tipoMoneda
            // 
            this.cb_tipoMoneda.FormattingEnabled = true;
            this.cb_tipoMoneda.Location = new System.Drawing.Point(222, 248);
            this.cb_tipoMoneda.Name = "cb_tipoMoneda";
            this.cb_tipoMoneda.Size = new System.Drawing.Size(218, 24);
            this.cb_tipoMoneda.TabIndex = 188;
            this.cb_tipoMoneda.Tag = "";
            this.cb_tipoMoneda.SelectedIndexChanged += new System.EventHandler(this.cb_tipoMoneda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 187;
            this.label1.Text = "Número de cuenta:";
            // 
            // txt_estado
            // 
            this.txt_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_estado.Location = new System.Drawing.Point(633, 252);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(287, 22);
            this.txt_estado.TabIndex = 186;
            this.txt_estado.Tag = "manac_alias";
            this.txt_estado.TextChanged += new System.EventHandler(this.txt_estado_TextChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fecha.Location = new System.Drawing.Point(633, 212);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(287, 22);
            this.txt_fecha.TabIndex = 185;
            this.txt_fecha.Tag = "regmon_fecha_de_registro";
            this.txt_fecha.Visible = false;
            // 
            // dgv_agCuentas
            // 
            this.dgv_agCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_agCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agCuentas.Location = new System.Drawing.Point(41, 391);
            this.dgv_agCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_agCuentas.Name = "dgv_agCuentas";
            this.dgv_agCuentas.RowHeadersWidth = 51;
            this.dgv_agCuentas.Size = new System.Drawing.Size(913, 451);
            this.dgv_agCuentas.TabIndex = 183;
            this.dgv_agCuentas.Tag = "tbl_mantenimientos_agregar_cuenta";
            // 
            // txt_tipo_moneda
            // 
            this.txt_tipo_moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tipo_moneda.Location = new System.Drawing.Point(222, 168);
            this.txt_tipo_moneda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipo_moneda.Name = "txt_tipo_moneda";
            this.txt_tipo_moneda.Size = new System.Drawing.Size(321, 22);
            this.txt_tipo_moneda.TabIndex = 184;
            this.txt_tipo_moneda.Tag = "manac_numero_de_cuenta";
            this.txt_tipo_moneda.TextChanged += new System.EventHandler(this.txt_tipo_moneda_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 182;
            this.label2.Text = "moneda de origen";
            // 
            // txt_tipo_mon
            // 
            this.txt_tipo_mon.Enabled = false;
            this.txt_tipo_mon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_mon.Location = new System.Drawing.Point(222, 278);
            this.txt_tipo_mon.Name = "txt_tipo_mon";
            this.txt_tipo_mon.ReadOnly = true;
            this.txt_tipo_mon.Size = new System.Drawing.Size(218, 26);
            this.txt_tipo_mon.TabIndex = 197;
            this.txt_tipo_mon.Tag = "fk_manac_tipo_de_moneda";
            this.txt_tipo_mon.Visible = false;
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(41, 30);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 198;
            // 
            // frm_mant_agregar_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 636);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_tipo_mon);
            this.Controls.Add(this.txt_tipocuenta);
            this.Controls.Add(this.txt_sect_banco);
            this.Controls.Add(this.cb_Banco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_tipocuenta);
            this.Controls.Add(this.cb_tipoMoneda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.dgv_agCuentas);
            this.Controls.Add(this.txt_tipo_moneda);
            this.Controls.Add(this.label2);
            this.Name = "frm_mant_agregar_cuenta";
            this.Text = "frm_mant_agregar_cuenta";
            this.Load += new System.EventHandler(this.frm_mant_agregar_cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tipocuenta;
        private System.Windows.Forms.TextBox txt_sect_banco;
        private System.Windows.Forms.ComboBox cb_Banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tipocuenta;
        private System.Windows.Forms.ComboBox cb_tipoMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.DataGridView dgv_agCuentas;
        private System.Windows.Forms.TextBox txt_tipo_moneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tipo_mon;
        private CapaVista.Navegador navegador1;
    }
}