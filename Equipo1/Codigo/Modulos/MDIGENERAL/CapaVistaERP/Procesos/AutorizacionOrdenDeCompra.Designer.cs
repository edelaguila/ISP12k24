
namespace CapaVistaERP.Procesos
{
    partial class AutorizacionOrdenDeCompra
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aprobar = new System.Windows.Forms.Button();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_saldoDisponible = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fechaAutorizacion = new System.Windows.Forms.DateTimePicker();
            this.cb_numeroOrden = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cuenta = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_NoCuenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_estadoCuenta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_departamentoSolicitante = new System.Windows.Forms.TextBox();
            this.txt_entregarPersona = new System.Windows.Forms.TextBox();
            this.txt_fechaSolicitud = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_fechaEntrega = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_IDCUENTA = new System.Windows.Forms.TextBox();
            this.txt_estadoOrden = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(468, 495);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(105, 58);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.Location = new System.Drawing.Point(348, 495);
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(105, 58);
            this.btn_aprobar.TabIndex = 30;
            this.btn_aprobar.Text = "Verificar y aprobar";
            this.btn_aprobar.UseVisualStyleBackColor = true;
            this.btn_aprobar.Click += new System.EventHandler(this.btn_aprobar_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(26, 450);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(287, 103);
            this.txt_Descripcion.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 27;
            // 
            // txt_saldoDisponible
            // 
            this.txt_saldoDisponible.Enabled = false;
            this.txt_saldoDisponible.Location = new System.Drawing.Point(154, 31);
            this.txt_saldoDisponible.Name = "txt_saldoDisponible";
            this.txt_saldoDisponible.Size = new System.Drawing.Size(95, 22);
            this.txt_saldoDisponible.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 34);
            this.label8.TabIndex = 5;
            this.label8.Text = "Saldo Disponible \r\nde la cuenta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fechaEntrega);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txt_fechaSolicitud);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_entregarPersona);
            this.groupBox1.Controls.Add(this.txt_departamentoSolicitante);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cb_numeroOrden);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 370);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de orden";
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Enabled = false;
            this.txt_subTotal.Location = new System.Drawing.Point(110, 32);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.Size = new System.Drawing.Size(95, 22);
            this.txt_subTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sub total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total de la orden:";
            // 
            // txt_totalOrden
            // 
            this.txt_totalOrden.Enabled = false;
            this.txt_totalOrden.Location = new System.Drawing.Point(154, 77);
            this.txt_totalOrden.Name = "txt_totalOrden";
            this.txt_totalOrden.Size = new System.Drawing.Size(95, 22);
            this.txt_totalOrden.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuenta asociada";
            // 
            // dtp_fechaAutorizacion
            // 
            this.dtp_fechaAutorizacion.Location = new System.Drawing.Point(351, 450);
            this.dtp_fechaAutorizacion.Name = "dtp_fechaAutorizacion";
            this.dtp_fechaAutorizacion.Size = new System.Drawing.Size(265, 22);
            this.dtp_fechaAutorizacion.TabIndex = 24;
            this.dtp_fechaAutorizacion.Value = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            // 
            // cb_numeroOrden
            // 
            this.cb_numeroOrden.FormattingEnabled = true;
            this.cb_numeroOrden.Location = new System.Drawing.Point(185, 35);
            this.cb_numeroOrden.Name = "cb_numeroOrden";
            this.cb_numeroOrden.Size = new System.Drawing.Size(158, 24);
            this.cb_numeroOrden.TabIndex = 23;
            this.cb_numeroOrden.SelectedIndexChanged += new System.EventHandler(this.cb_numeroOrden_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de autorizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Comentarios:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Numero de orden";
            // 
            // cb_cuenta
            // 
            this.cb_cuenta.FormattingEnabled = true;
            this.cb_cuenta.Location = new System.Drawing.Point(154, 33);
            this.cb_cuenta.Name = "cb_cuenta";
            this.cb_cuenta.Size = new System.Drawing.Size(158, 24);
            this.cb_cuenta.TabIndex = 32;
            this.cb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cb_cuenta_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_IDCUENTA);
            this.groupBox3.Controls.Add(this.txt_NoCuenta);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cb_cuenta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_estadoCuenta);
            this.groupBox3.Location = new System.Drawing.Point(408, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 241);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la cuenta";
            // 
            // txt_NoCuenta
            // 
            this.txt_NoCuenta.Enabled = false;
            this.txt_NoCuenta.Location = new System.Drawing.Point(154, 121);
            this.txt_NoCuenta.Name = "txt_NoCuenta";
            this.txt_NoCuenta.Size = new System.Drawing.Size(158, 22);
            this.txt_NoCuenta.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Numero de cuenta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Estado de cuenta";
            // 
            // txt_estadoCuenta
            // 
            this.txt_estadoCuenta.Enabled = false;
            this.txt_estadoCuenta.Location = new System.Drawing.Point(154, 83);
            this.txt_estadoCuenta.Name = "txt_estadoCuenta";
            this.txt_estadoCuenta.Size = new System.Drawing.Size(158, 22);
            this.txt_estadoCuenta.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Iva aplicado:";
            // 
            // txt_iva
            // 
            this.txt_iva.Enabled = false;
            this.txt_iva.Location = new System.Drawing.Point(110, 70);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(95, 22);
            this.txt_iva.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Departamento Solicitante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Entregar a:";
            // 
            // txt_departamentoSolicitante
            // 
            this.txt_departamentoSolicitante.Enabled = false;
            this.txt_departamentoSolicitante.Location = new System.Drawing.Point(185, 75);
            this.txt_departamentoSolicitante.Name = "txt_departamentoSolicitante";
            this.txt_departamentoSolicitante.Size = new System.Drawing.Size(164, 22);
            this.txt_departamentoSolicitante.TabIndex = 16;
            // 
            // txt_entregarPersona
            // 
            this.txt_entregarPersona.Enabled = false;
            this.txt_entregarPersona.Location = new System.Drawing.Point(185, 112);
            this.txt_entregarPersona.Name = "txt_entregarPersona";
            this.txt_entregarPersona.Size = new System.Drawing.Size(164, 22);
            this.txt_entregarPersona.TabIndex = 17;
            // 
            // txt_fechaSolicitud
            // 
            this.txt_fechaSolicitud.Enabled = false;
            this.txt_fechaSolicitud.Location = new System.Drawing.Point(185, 151);
            this.txt_fechaSolicitud.Name = "txt_fechaSolicitud";
            this.txt_fechaSolicitud.Size = new System.Drawing.Size(164, 22);
            this.txt_fechaSolicitud.TabIndex = 25;
            this.txt_fechaSolicitud.TextChanged += new System.EventHandler(this.txt_fechaSolicitud_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Fecha de solicitud";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txt_fechaEntrega
            // 
            this.txt_fechaEntrega.Enabled = false;
            this.txt_fechaEntrega.Location = new System.Drawing.Point(185, 190);
            this.txt_fechaEntrega.Name = "txt_fechaEntrega";
            this.txt_fechaEntrega.Size = new System.Drawing.Size(164, 22);
            this.txt_fechaEntrega.TabIndex = 27;
            this.txt_fechaEntrega.TextChanged += new System.EventHandler(this.txt_fechaEntrega_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "Fecha de entrega\r";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_iva);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_subTotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(0, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 130);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valores de la orden";
            // 
            // txt_IDCUENTA
            // 
            this.txt_IDCUENTA.Enabled = false;
            this.txt_IDCUENTA.Location = new System.Drawing.Point(11, 213);
            this.txt_IDCUENTA.Name = "txt_IDCUENTA";
            this.txt_IDCUENTA.Size = new System.Drawing.Size(26, 22);
            this.txt_IDCUENTA.TabIndex = 33;
            this.txt_IDCUENTA.Visible = false;
            // 
            // txt_estadoOrden
            // 
            this.txt_estadoOrden.Enabled = false;
            this.txt_estadoOrden.Location = new System.Drawing.Point(704, 450);
            this.txt_estadoOrden.Name = "txt_estadoOrden";
            this.txt_estadoOrden.Size = new System.Drawing.Size(26, 22);
            this.txt_estadoOrden.TabIndex = 34;
            this.txt_estadoOrden.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_saldoDisponible);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_totalOrden);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(408, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 130);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comparacion";
            // 
            // AutorizacionOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_estadoOrden);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aprobar);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_fechaAutorizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "AutorizacionOrdenDeCompra";
            this.Text = "AutorizacionOrdenDeCompra";
            this.Load += new System.EventHandler(this.AutorizacionOrdenDeCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aprobar;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_saldoDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalOrden;
        private System.Windows.Forms.DateTimePicker dtp_fechaAutorizacion;
        private System.Windows.Forms.ComboBox cb_numeroOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cuenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_NoCuenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_estadoCuenta;
        private System.Windows.Forms.TextBox txt_fechaEntrega;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_fechaSolicitud;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_entregarPersona;
        private System.Windows.Forms.TextBox txt_departamentoSolicitante;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_IDCUENTA;
        private System.Windows.Forms.TextBox txt_estadoOrden;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}