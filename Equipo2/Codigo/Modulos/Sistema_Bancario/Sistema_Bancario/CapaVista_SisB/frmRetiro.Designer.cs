
namespace CapaVista_SisB
{
    partial class frmRetiro
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
            this.btn_genCodigo = new System.Windows.Forms.Button();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_moneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_codigoSeguridad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_genCodigo
            // 
            this.btn_genCodigo.BackColor = System.Drawing.Color.SlateGray;
            this.btn_genCodigo.FlatAppearance.BorderSize = 0;
            this.btn_genCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_genCodigo.Location = new System.Drawing.Point(103, 442);
            this.btn_genCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_genCodigo.Name = "btn_genCodigo";
            this.btn_genCodigo.Size = new System.Drawing.Size(181, 44);
            this.btn_genCodigo.TabIndex = 58;
            this.btn_genCodigo.Text = "Generar Codigo";
            this.btn_genCodigo.UseVisualStyleBackColor = false;
            this.btn_genCodigo.Click += new System.EventHandler(this.btn_genCodigo_Click);
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_cuenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuenta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_cuenta.Location = new System.Drawing.Point(103, 267);
            this.txt_cuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cuenta.Multiline = true;
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(335, 36);
            this.txt_cuenta.TabIndex = 57;
            this.txt_cuenta.Tag = "Cantidad_a_retirar";
            this.txt_cuenta.Text = "Q. 100";
            this.txt_cuenta.TextChanged += new System.EventHandler(this.txt_cuenta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(99, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Monto a retirar";
            // 
            // cmb_moneda
            // 
            this.cmb_moneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_moneda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_moneda.FormattingEnabled = true;
            this.cmb_moneda.Location = new System.Drawing.Point(103, 174);
            this.cmb_moneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_moneda.Name = "cmb_moneda";
            this.cmb_moneda.Size = new System.Drawing.Size(335, 28);
            this.cmb_moneda.TabIndex = 53;
            this.cmb_moneda.Text = "BI - 3425436 Oliver Tzunun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(99, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cuenta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.panel1.Location = new System.Drawing.Point(103, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 5);
            this.panel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 50;
            this.label1.Text = "Retiro";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(521, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 561);
            this.panel2.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista_SisB.Properties.Resources.qr_code;
            this.pictureBox1.Location = new System.Drawing.Point(69, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(208)))), ((int)(((byte)(222)))));
            this.panel4.Controls.Add(this.lbl_codigoSeguridad);
            this.panel4.Location = new System.Drawing.Point(69, 122);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 122);
            this.panel4.TabIndex = 4;
            // 
            // lbl_codigoSeguridad
            // 
            this.lbl_codigoSeguridad.AutoSize = true;
            this.lbl_codigoSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigoSeguridad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoSeguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_codigoSeguridad.Location = new System.Drawing.Point(105, 38);
            this.lbl_codigoSeguridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigoSeguridad.Name = "lbl_codigoSeguridad";
            this.lbl_codigoSeguridad.Size = new System.Drawing.Size(181, 40);
            this.lbl_codigoSeguridad.TabIndex = 5;
            this.lbl_codigoSeguridad.Text = "7 8 5 9 4 2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(84, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 5);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(63, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Información de retiro";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Location = new System.Drawing.Point(103, 372);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(335, 36);
            this.textBox3.TabIndex = 61;
            this.textBox3.Tag = "Cantidad_a_retirar";
            this.textBox3.Text = "Pago de luz...";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(41)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(99, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Comentario";
            // 
            // frmRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_genCodigo);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_moneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRetiro";
            this.Text = "frmRetiro";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_genCodigo;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_moneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_codigoSeguridad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}