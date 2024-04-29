
namespace CapaVistaERP.Procesos
{
    partial class TrasladoDeProducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_NombreProd = new System.Windows.Forms.ComboBox();
            this.txt_CantidadTraslado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_OrigenSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_destinoSucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(317, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 46);
            this.button1.TabIndex = 60;
            this.button1.Text = "Guardar Traslado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_NombreProd);
            this.groupBox2.Controls.Add(this.txt_CantidadTraslado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(71, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 132);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // cb_NombreProd
            // 
            this.cb_NombreProd.FormattingEnabled = true;
            this.cb_NombreProd.Location = new System.Drawing.Point(174, 58);
            this.cb_NombreProd.Name = "cb_NombreProd";
            this.cb_NombreProd.Size = new System.Drawing.Size(146, 24);
            this.cb_NombreProd.TabIndex = 11;
            // 
            // txt_CantidadTraslado
            // 
            this.txt_CantidadTraslado.Location = new System.Drawing.Point(462, 58);
            this.txt_CantidadTraslado.Name = "txt_CantidadTraslado";
            this.txt_CantidadTraslado.Size = new System.Drawing.Size(156, 22);
            this.txt_CantidadTraslado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(387, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(37, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "TRASLADO DE PRODUCTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_OrigenSucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_destinoSucursal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(273, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 142);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentación";
            // 
            // cb_OrigenSucursal
            // 
            this.cb_OrigenSucursal.FormattingEnabled = true;
            this.cb_OrigenSucursal.Location = new System.Drawing.Point(136, 44);
            this.cb_OrigenSucursal.Name = "cb_OrigenSucursal";
            this.cb_OrigenSucursal.Size = new System.Drawing.Size(146, 24);
            this.cb_OrigenSucursal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Origen:";
            // 
            // cb_destinoSucursal
            // 
            this.cb_destinoSucursal.FormattingEnabled = true;
            this.cb_destinoSucursal.Location = new System.Drawing.Point(136, 94);
            this.cb_destinoSucursal.Name = "cb_destinoSucursal";
            this.cb_destinoSucursal.Size = new System.Drawing.Size(146, 24);
            this.cb_destinoSucursal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destino:";
            // 
            // TrasladoDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrasladoDeProducto";
            this.Text = "TrasladoDeProducto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_NombreProd;
        private System.Windows.Forms.TextBox txt_CantidadTraslado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_OrigenSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_destinoSucursal;
        private System.Windows.Forms.Label label3;
    }
}