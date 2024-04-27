
namespace CapaVistaERP.Procesos
{
    partial class Dispo_Diaria
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoDisponible = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFondoRetiro = new System.Windows.Forms.TextBox();
            this.textsaldoactual = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_IDBanco = new System.Windows.Forms.TextBox();
            this.txtIdBanco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botton3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstadoBanco = new System.Windows.Forms.TextBox();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.txt_IDCUENTAB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_estadoCuenta = new System.Windows.Forms.TextBox();
            this.btn_rtrans = new System.Windows.Forms.Button();
            this.btn_cancelarTransaccion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipoCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_noCuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreCuenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_cuenta = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(407, 803);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(246, 31);
            this.Cancelar.TabIndex = 153;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(97, 803);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(234, 31);
            this.Registrar.TabIndex = 152;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Visible = false;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_fecha);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSaldoDisponible);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Calcular);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtFondoRetiro);
            this.groupBox3.Controls.Add(this.textsaldoactual);
            this.groupBox3.Location = new System.Drawing.Point(26, 565);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 199);
            this.groupBox3.TabIndex = 151;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saldos";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(477, 77);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.dtp_fecha.TabIndex = 144;
            this.dtp_fecha.Value = new System.DateTime(2024, 4, 26, 0, 0, 0, 0);
            this.dtp_fecha.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 141;
            this.label6.Text = "Saldo Disponible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 143;
            this.label8.Text = "Fecha";
            this.label8.Visible = false;
            // 
            // txtSaldoDisponible
            // 
            this.txtSaldoDisponible.Enabled = false;
            this.txtSaldoDisponible.Location = new System.Drawing.Point(484, 155);
            this.txtSaldoDisponible.Name = "txtSaldoDisponible";
            this.txtSaldoDisponible.Size = new System.Drawing.Size(172, 22);
            this.txtSaldoDisponible.TabIndex = 142;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 140;
            this.label11.Visible = false;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(71, 48);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(105, 31);
            this.Calcular.TabIndex = 139;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Visible = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(372, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "agregar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(372, 33);
            this.button6.TabIndex = 13;
            this.button6.Text = "Cancelar ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 133;
            this.label12.Text = "saldo actual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 17);
            this.label13.TabIndex = 134;
            this.label13.Text = "Fondos Retirados";
            // 
            // txtFondoRetiro
            // 
            this.txtFondoRetiro.Enabled = false;
            this.txtFondoRetiro.Location = new System.Drawing.Point(277, 155);
            this.txtFondoRetiro.Name = "txtFondoRetiro";
            this.txtFondoRetiro.Size = new System.Drawing.Size(172, 22);
            this.txtFondoRetiro.TabIndex = 138;
            // 
            // textsaldoactual
            // 
            this.textsaldoactual.Enabled = false;
            this.textsaldoactual.Location = new System.Drawing.Point(71, 155);
            this.textsaldoactual.Name = "textsaldoactual";
            this.textsaldoactual.Size = new System.Drawing.Size(172, 22);
            this.textsaldoactual.TabIndex = 137;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_IDBanco);
            this.groupBox2.Controls.Add(this.txtIdBanco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.botton3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEstadoBanco);
            this.groupBox2.Controls.Add(this.txtNombreBanco);
            this.groupBox2.Location = new System.Drawing.Point(424, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 277);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Banco";
            // 
            // txt_IDBanco
            // 
            this.txt_IDBanco.Enabled = false;
            this.txt_IDBanco.Location = new System.Drawing.Point(277, 97);
            this.txt_IDBanco.Name = "txt_IDBanco";
            this.txt_IDBanco.Size = new System.Drawing.Size(36, 22);
            this.txt_IDBanco.TabIndex = 145;
            this.txt_IDBanco.Visible = false;
            // 
            // txtIdBanco
            // 
            this.txtIdBanco.FormattingEnabled = true;
            this.txtIdBanco.Location = new System.Drawing.Point(71, 97);
            this.txtIdBanco.Name = "txtIdBanco";
            this.txtIdBanco.Size = new System.Drawing.Size(200, 24);
            this.txtIdBanco.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 140;
            this.label4.Text = "Buscar informacion";
            this.label4.Visible = false;
            // 
            // botton3
            // 
            this.botton3.Location = new System.Drawing.Point(201, 38);
            this.botton3.Name = "botton3";
            this.botton3.Size = new System.Drawing.Size(90, 31);
            this.botton3.TabIndex = 139;
            this.botton3.Text = "Buscar";
            this.botton3.UseVisualStyleBackColor = true;
            this.botton3.Visible = false;
            this.botton3.Click += new System.EventHandler(this.botton3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 133;
            this.label2.Text = "Nombre de banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 134;
            this.label3.Text = "Estado";
            // 
            // txtEstadoBanco
            // 
            this.txtEstadoBanco.Enabled = false;
            this.txtEstadoBanco.Location = new System.Drawing.Point(71, 221);
            this.txtEstadoBanco.Name = "txtEstadoBanco";
            this.txtEstadoBanco.Size = new System.Drawing.Size(200, 22);
            this.txtEstadoBanco.TabIndex = 138;
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Enabled = false;
            this.txtNombreBanco.Location = new System.Drawing.Point(71, 155);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(200, 22);
            this.txtNombreBanco.TabIndex = 137;
            // 
            // txt_IDCUENTAB
            // 
            this.txt_IDCUENTAB.Enabled = false;
            this.txt_IDCUENTAB.Location = new System.Drawing.Point(384, 23);
            this.txt_IDCUENTAB.Name = "txt_IDCUENTAB";
            this.txt_IDCUENTAB.Size = new System.Drawing.Size(36, 22);
            this.txt_IDCUENTAB.TabIndex = 147;
            this.txt_IDCUENTAB.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_estadoCuenta);
            this.groupBox1.Controls.Add(this.btn_rtrans);
            this.groupBox1.Controls.Add(this.btn_cancelarTransaccion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_tipoCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_noCuenta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nombreCuenta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 277);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cuenta";
            // 
            // txt_estadoCuenta
            // 
            this.txt_estadoCuenta.Enabled = false;
            this.txt_estadoCuenta.Location = new System.Drawing.Point(43, 232);
            this.txt_estadoCuenta.Name = "txt_estadoCuenta";
            this.txt_estadoCuenta.Size = new System.Drawing.Size(172, 22);
            this.txt_estadoCuenta.TabIndex = 140;
            // 
            // btn_rtrans
            // 
            this.btn_rtrans.Location = new System.Drawing.Point(0, 271);
            this.btn_rtrans.Name = "btn_rtrans";
            this.btn_rtrans.Size = new System.Drawing.Size(372, 33);
            this.btn_rtrans.TabIndex = 10;
            this.btn_rtrans.Text = "agregar";
            this.btn_rtrans.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarTransaccion
            // 
            this.btn_cancelarTransaccion.Location = new System.Drawing.Point(0, 310);
            this.btn_cancelarTransaccion.Name = "btn_cancelarTransaccion";
            this.btn_cancelarTransaccion.Size = new System.Drawing.Size(372, 33);
            this.btn_cancelarTransaccion.TabIndex = 13;
            this.btn_cancelarTransaccion.Text = "Cancelar ";
            this.btn_cancelarTransaccion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 133;
            this.label7.Text = "Nombre de la cuenta";
            // 
            // txt_tipoCuenta
            // 
            this.txt_tipoCuenta.Enabled = false;
            this.txt_tipoCuenta.Location = new System.Drawing.Point(43, 180);
            this.txt_tipoCuenta.Name = "txt_tipoCuenta";
            this.txt_tipoCuenta.Size = new System.Drawing.Size(172, 22);
            this.txt_tipoCuenta.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 134;
            this.label1.Text = "No. cuenta";
            // 
            // txt_noCuenta
            // 
            this.txt_noCuenta.Enabled = false;
            this.txt_noCuenta.Location = new System.Drawing.Point(43, 130);
            this.txt_noCuenta.Name = "txt_noCuenta";
            this.txt_noCuenta.Size = new System.Drawing.Size(172, 22);
            this.txt_noCuenta.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 135;
            this.label9.Text = "Tipo de cuenta";
            // 
            // txt_nombreCuenta
            // 
            this.txt_nombreCuenta.Enabled = false;
            this.txt_nombreCuenta.Location = new System.Drawing.Point(43, 65);
            this.txt_nombreCuenta.Name = "txt_nombreCuenta";
            this.txt_nombreCuenta.Size = new System.Drawing.Size(172, 22);
            this.txt_nombreCuenta.TabIndex = 137;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 136;
            this.label10.Text = "Estado actual";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 361);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(747, 190);
            this.dataGridView1.TabIndex = 145;
            this.dataGridView1.Tag = "tbl_mantenimientos_agregar_bancos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 148;
            this.label5.Text = "Selecionar cuenta";
            // 
            // cb_cuenta
            // 
            this.cb_cuenta.FormattingEnabled = true;
            this.cb_cuenta.Location = new System.Drawing.Point(160, 21);
            this.cb_cuenta.Name = "cb_cuenta";
            this.cb_cuenta.Size = new System.Drawing.Size(215, 24);
            this.cb_cuenta.TabIndex = 149;
            this.cb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cb_cuenta_SelectedIndexChanged);
            // 
            // Dispo_Diaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 859);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_IDCUENTAB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_cuenta);
            this.Name = "Dispo_Diaria";
            this.Text = "Dispo_Diaria";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldoDisponible;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFondoRetiro;
        private System.Windows.Forms.TextBox textsaldoactual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_IDBanco;
        private System.Windows.Forms.ComboBox txtIdBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstadoBanco;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.TextBox txt_IDCUENTAB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_estadoCuenta;
        private System.Windows.Forms.Button btn_rtrans;
        private System.Windows.Forms.Button btn_cancelarTransaccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipoCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_noCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreCuenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_cuenta;
    }
}