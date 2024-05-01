namespace CapaVistaERP.Procesos
{
    partial class CajaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajaProveedor));
            this.cmb_tipo = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_bancos = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_beneficiario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.dt_fechaabono = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tipotransa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_banco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_totalapagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pagoproveedor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_idprov = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nombreprov = new System.Windows.Forms.TextBox();
            this.txt_nitprov = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.btn_buscarFactura = new System.Windows.Forms.Button();
            this.cmb_tipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagoproveedor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.Controls.Add(this.textBox1);
            this.cmb_tipo.Controls.Add(this.txt_bancos);
            this.cmb_tipo.Controls.Add(this.btn_cancelar);
            this.cmb_tipo.Controls.Add(this.txt_concepto);
            this.cmb_tipo.Controls.Add(this.label9);
            this.cmb_tipo.Controls.Add(this.txt_beneficiario);
            this.cmb_tipo.Controls.Add(this.label8);
            this.cmb_tipo.Controls.Add(this.btn_pagar);
            this.cmb_tipo.Controls.Add(this.dt_fechaabono);
            this.cmb_tipo.Controls.Add(this.label7);
            this.cmb_tipo.Controls.Add(this.txt_numero);
            this.cmb_tipo.Controls.Add(this.label6);
            this.cmb_tipo.Controls.Add(this.cb_tipotransa);
            this.cmb_tipo.Controls.Add(this.label5);
            this.cmb_tipo.Controls.Add(this.cmb_banco);
            this.cmb_tipo.Controls.Add(this.label4);
            this.cmb_tipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.Location = new System.Drawing.Point(13, 646);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Padding = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Size = new System.Drawing.Size(1024, 271);
            this.cmb_tipo.TabIndex = 45;
            this.cmb_tipo.TabStop = false;
            this.cmb_tipo.Text = "Pago";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(728, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 24);
            this.textBox1.TabIndex = 56;
            // 
            // txt_bancos
            // 
            this.txt_bancos.Enabled = false;
            this.txt_bancos.Location = new System.Drawing.Point(315, 37);
            this.txt_bancos.Name = "txt_bancos";
            this.txt_bancos.Size = new System.Drawing.Size(52, 24);
            this.txt_bancos.TabIndex = 55;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(797, 181);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(148, 46);
            this.btn_cancelar.TabIndex = 54;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(61, 216);
            this.txt_concepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(652, 36);
            this.txt_concepto.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Concepto";
            // 
            // txt_beneficiario
            // 
            this.txt_beneficiario.Location = new System.Drawing.Point(162, 141);
            this.txt_beneficiario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_beneficiario.Name = "txt_beneficiario";
            this.txt_beneficiario.Size = new System.Drawing.Size(551, 24);
            this.txt_beneficiario.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Beneficiario";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(797, 105);
            this.btn_pagar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(148, 46);
            this.btn_pagar.TabIndex = 49;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            // 
            // dt_fechaabono
            // 
            this.dt_fechaabono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaabono.Location = new System.Drawing.Point(552, 93);
            this.dt_fechaabono.Margin = new System.Windows.Forms.Padding(4);
            this.dt_fechaabono.Name = "dt_fechaabono";
            this.dt_fechaabono.Size = new System.Drawing.Size(161, 24);
            this.dt_fechaabono.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Fecha abono";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(148, 89);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(161, 24);
            this.txt_numero.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Número";
            // 
            // cb_tipotransa
            // 
            this.cb_tipotransa.FormattingEnabled = true;
            this.cb_tipotransa.Location = new System.Drawing.Point(552, 37);
            this.cb_tipotransa.Name = "cb_tipotransa";
            this.cb_tipotransa.Size = new System.Drawing.Size(161, 27);
            this.cb_tipotransa.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tipo";
            // 
            // cmb_banco
            // 
            this.cmb_banco.FormattingEnabled = true;
            this.cmb_banco.Location = new System.Drawing.Point(148, 37);
            this.cmb_banco.Name = "cmb_banco";
            this.cmb_banco.Size = new System.Drawing.Size(161, 27);
            this.cmb_banco.TabIndex = 42;
            this.cmb_banco.SelectedIndexChanged += new System.EventHandler(this.cmb_banco_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Banco";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscarFactura);
            this.groupBox1.Controls.Add(this.txt_totalapagar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nit);
            this.groupBox1.Controls.Add(this.dgv_pagoproveedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 224);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1024, 403);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimientos";
            // 
            // txt_totalapagar
            // 
            this.txt_totalapagar.Location = new System.Drawing.Point(790, 356);
            this.txt_totalapagar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalapagar.Name = "txt_totalapagar";
            this.txt_totalapagar.Size = new System.Drawing.Size(184, 24);
            this.txt_totalapagar.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total a pagar";
            // 
            // dgv_pagoproveedor
            // 
            this.dgv_pagoproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pagoproveedor.Location = new System.Drawing.Point(31, 56);
            this.dgv_pagoproveedor.Name = "dgv_pagoproveedor";
            this.dgv_pagoproveedor.RowHeadersWidth = 51;
            this.dgv_pagoproveedor.RowTemplate.Height = 24;
            this.dgv_pagoproveedor.Size = new System.Drawing.Size(943, 293);
            this.dgv_pagoproveedor.TabIndex = 38;
            this.dgv_pagoproveedor.Tag = "tbl_facturaxpagar";
            this.dgv_pagoproveedor.SelectionChanged += new System.EventHandler(this.dgv_pagoproveedor_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_idprov);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_nombreprov);
            this.groupBox2.Controls.Add(this.txt_nitprov);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1024, 198);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "ID Proveedor";
            // 
            // txt_idprov
            // 
            this.txt_idprov.Enabled = false;
            this.txt_idprov.Location = new System.Drawing.Point(215, 30);
            this.txt_idprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idprov.Multiline = true;
            this.txt_idprov.Name = "txt_idprov";
            this.txt_idprov.Size = new System.Drawing.Size(349, 26);
            this.txt_idprov.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nombre";
            // 
            // txt_nombreprov
            // 
            this.txt_nombreprov.Enabled = false;
            this.txt_nombreprov.Location = new System.Drawing.Point(215, 76);
            this.txt_nombreprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreprov.Name = "txt_nombreprov";
            this.txt_nombreprov.Size = new System.Drawing.Size(349, 23);
            this.txt_nombreprov.TabIndex = 20;
            // 
            // txt_nitprov
            // 
            this.txt_nitprov.Enabled = false;
            this.txt_nitprov.Location = new System.Drawing.Point(215, 118);
            this.txt_nitprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nitprov.Name = "txt_nitprov";
            this.txt_nitprov.Size = new System.Drawing.Size(349, 23);
            this.txt_nitprov.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "NIT";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(576, 31);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 25);
            this.btn_buscar.TabIndex = 22;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "NIT Proveedor";
            // 
            // txt_nit
            // 
            this.txt_nit.Enabled = false;
            this.txt_nit.Location = new System.Drawing.Point(152, 25);
            this.txt_nit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(309, 24);
            this.txt_nit.TabIndex = 37;
            this.txt_nit.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // btn_buscarFactura
            // 
            this.btn_buscarFactura.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscarFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarFactura.BackgroundImage")));
            this.btn_buscarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarFactura.Location = new System.Drawing.Point(510, 24);
            this.btn_buscarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarFactura.Name = "btn_buscarFactura";
            this.btn_buscarFactura.Size = new System.Drawing.Size(33, 25);
            this.btn_buscarFactura.TabIndex = 41;
            this.btn_buscarFactura.UseVisualStyleBackColor = false;
            this.btn_buscarFactura.Click += new System.EventHandler(this.btn_buscarFactura_Click);
            // 
            // CajaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 931);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.groupBox1);
            this.Name = "CajaProveedor";
            this.Text = "OperacionesProveedor";
            this.cmb_tipo.ResumeLayout(false);
            this.cmb_tipo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagoproveedor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cmb_tipo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_beneficiario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.DateTimePicker dt_fechaabono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_tipotransa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_totalapagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pagoproveedor;
        private System.Windows.Forms.TextBox txt_bancos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_idprov;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nombreprov;
        private System.Windows.Forms.TextBox txt_nitprov;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Button btn_buscarFactura;
    }
}