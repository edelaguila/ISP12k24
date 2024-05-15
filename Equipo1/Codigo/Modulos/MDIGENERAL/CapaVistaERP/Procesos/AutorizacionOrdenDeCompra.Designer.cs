
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizacionOrdenDeCompra));
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_saldoDisponible = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fechaEntrega = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_fechaSolicitud = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_entregarPersona = new System.Windows.Forms.TextBox();
            this.txt_departamentoSolicitante = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_numeroOrden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fechaAutorizacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_cuenta = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_IDCUENTA = new System.Windows.Forms.TextBox();
            this.txt_NoCuenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_estadoCuenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ayudas = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.lb_respuesta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.positivo = new System.Windows.Forms.Panel();
            this.negativo = new System.Windows.Forms.Panel();
            this.espera = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.negativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(770, 50);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(265, 103);
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
            // txt_iva
            // 
            this.txt_iva.Enabled = false;
            this.txt_iva.Location = new System.Drawing.Point(110, 70);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(95, 22);
            this.txt_iva.TabIndex = 13;
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
            // txt_subTotal
            // 
            this.txt_subTotal.Enabled = false;
            this.txt_subTotal.Location = new System.Drawing.Point(110, 32);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.Size = new System.Drawing.Size(95, 22);
            this.txt_subTotal.TabIndex = 11;
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
            // txt_entregarPersona
            // 
            this.txt_entregarPersona.Enabled = false;
            this.txt_entregarPersona.Location = new System.Drawing.Point(185, 112);
            this.txt_entregarPersona.Name = "txt_entregarPersona";
            this.txt_entregarPersona.Size = new System.Drawing.Size(164, 22);
            this.txt_entregarPersona.TabIndex = 17;
            // 
            // txt_departamentoSolicitante
            // 
            this.txt_departamentoSolicitante.Enabled = false;
            this.txt_departamentoSolicitante.Location = new System.Drawing.Point(185, 75);
            this.txt_departamentoSolicitante.Name = "txt_departamentoSolicitante";
            this.txt_departamentoSolicitante.Size = new System.Drawing.Size(164, 22);
            this.txt_departamentoSolicitante.TabIndex = 16;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "Departamento Solicitante";
            // 
            // cb_numeroOrden
            // 
            this.cb_numeroOrden.FormattingEnabled = true;
            this.cb_numeroOrden.Location = new System.Drawing.Point(185, 35);
            this.cb_numeroOrden.Name = "cb_numeroOrden";
            this.cb_numeroOrden.Size = new System.Drawing.Size(158, 24);
            this.cb_numeroOrden.TabIndex = 23;
            this.cb_numeroOrden.Text = "Seleccionar";
            this.cb_numeroOrden.SelectedIndexChanged += new System.EventHandler(this.cb_numeroOrden_SelectedIndexChanged);
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
            this.dtp_fechaAutorizacion.Location = new System.Drawing.Point(770, 266);
            this.dtp_fechaAutorizacion.Name = "dtp_fechaAutorizacion";
            this.dtp_fechaAutorizacion.Size = new System.Drawing.Size(265, 22);
            this.dtp_fechaAutorizacion.TabIndex = 24;
            this.dtp_fechaAutorizacion.Value = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(767, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de autorizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Observaciones:";
            // 
            // cb_cuenta
            // 
            this.cb_cuenta.FormattingEnabled = true;
            this.cb_cuenta.Location = new System.Drawing.Point(154, 33);
            this.cb_cuenta.Name = "cb_cuenta";
            this.cb_cuenta.Size = new System.Drawing.Size(158, 24);
            this.cb_cuenta.TabIndex = 32;
            this.cb_cuenta.Text = "Seleccionar";
            this.cb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cb_cuenta_SelectedIndexChanged);
            // 
            // groupBox3
            // 
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
            // txt_IDCUENTA
            // 
            this.txt_IDCUENTA.Enabled = false;
            this.txt_IDCUENTA.Location = new System.Drawing.Point(688, 23);
            this.txt_IDCUENTA.Name = "txt_IDCUENTA";
            this.txt_IDCUENTA.Size = new System.Drawing.Size(26, 22);
            this.txt_IDCUENTA.TabIndex = 33;
            this.txt_IDCUENTA.Visible = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_verificar);
            this.panel1.Controls.Add(this.txt_IDCUENTA);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_ayudas);
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Location = new System.Drawing.Point(24, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 101);
            this.panel1.TabIndex = 36;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Snow;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salir.Location = new System.Drawing.Point(375, 13);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(84, 71);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Regresar";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ayudas
            // 
            this.btn_ayudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_ayudas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayudas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayudas.ForeColor = System.Drawing.Color.Snow;
            this.btn_ayudas.Image = ((System.Drawing.Image)(resources.GetObject("btn_ayudas.Image")));
            this.btn_ayudas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ayudas.Location = new System.Drawing.Point(285, 13);
            this.btn_ayudas.Name = "btn_ayudas";
            this.btn_ayudas.Size = new System.Drawing.Size(84, 71);
            this.btn_ayudas.TabIndex = 5;
            this.btn_ayudas.Text = "Ayuda";
            this.btn_ayudas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ayudas.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.Snow;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_limpiar.Location = new System.Drawing.Point(195, 13);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(84, 71);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Snow;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(105, 13);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(84, 71);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Nuevo";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_verificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.ForeColor = System.Drawing.Color.Snow;
            this.btn_verificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_verificar.Image")));
            this.btn_verificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_verificar.Location = new System.Drawing.Point(15, 13);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(84, 71);
            this.btn_verificar.TabIndex = 35;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // lb_respuesta
            // 
            this.lb_respuesta.AutoSize = true;
            this.lb_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_respuesta.Location = new System.Drawing.Point(19, 31);
            this.lb_respuesta.Name = "lb_respuesta";
            this.lb_respuesta.Size = new System.Drawing.Size(113, 20);
            this.lb_respuesta.TabIndex = 37;
            this.lb_respuesta.Text = "Esperando...";
            this.lb_respuesta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.negativo);
            this.panel2.Controls.Add(this.positivo);
            this.panel2.Controls.Add(this.lb_respuesta);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(770, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 182);
            this.panel2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Estado:";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Aprobado",
            "No aprobado",
            "En espera"});
            this.cb_estado.Location = new System.Drawing.Point(770, 192);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(265, 24);
            this.cb_estado.TabIndex = 33;
            this.cb_estado.Text = "Seleccionar";
            // 
            // positivo
            // 
            this.positivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("positivo.BackgroundImage")));
            this.positivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.positivo.Location = new System.Drawing.Point(95, 94);
            this.positivo.Name = "positivo";
            this.positivo.Size = new System.Drawing.Size(68, 59);
            this.positivo.TabIndex = 38;
            this.positivo.Visible = false;
            this.positivo.Paint += new System.Windows.Forms.PaintEventHandler(this.positivo_Paint);
            // 
            // negativo
            // 
            this.negativo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("negativo.BackgroundImage")));
            this.negativo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.negativo.Controls.Add(this.espera);
            this.negativo.Location = new System.Drawing.Point(95, 94);
            this.negativo.Name = "negativo";
            this.negativo.Size = new System.Drawing.Size(68, 59);
            this.negativo.TabIndex = 39;
            this.negativo.Visible = false;
            // 
            // espera
            // 
            this.espera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("espera.BackgroundImage")));
            this.espera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.espera.Location = new System.Drawing.Point(0, 0);
            this.espera.Name = "espera";
            this.espera.Size = new System.Drawing.Size(68, 59);
            this.espera.TabIndex = 40;
            this.espera.Paint += new System.Windows.Forms.PaintEventHandler(this.espera_Paint);
            // 
            // AutorizacionOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 531);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.negativo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ayudas;
        public System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label lb_respuesta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel positivo;
        private System.Windows.Forms.Panel negativo;
        private System.Windows.Forms.Panel espera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_estado;
    }
}