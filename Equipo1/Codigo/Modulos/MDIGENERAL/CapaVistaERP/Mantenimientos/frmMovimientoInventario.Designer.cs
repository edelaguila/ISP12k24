
namespace CapaVistaERP.Mantenimientos
{
    partial class frmMovimientoInventario
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
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Movimiento = new System.Windows.Forms.ComboBox();
            this.txt_Descrip = new System.Windows.Forms.TextBox();
            this.txt_IDMov = new System.Windows.Forms.TextBox();
            this.dgv_MovimientoInv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CantidadMov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Sucursal = new System.Windows.Forms.ComboBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.txt_Movimiento = new System.Windows.Forms.TextBox();
            this.txt_Sucursal = new System.Windows.Forms.TextBox();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MovimientoInv)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label12.Location = new System.Drawing.Point(593, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "Sucursal:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(283, 259);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(187, 22);
            this.dtp_Fecha.TabIndex = 44;
            this.dtp_Fecha.Tag = "fecha_movimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(335, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "MOVIMIENTO DE INVENTARIO";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cb_Movimiento
            // 
            this.cb_Movimiento.FormattingEnabled = true;
            this.cb_Movimiento.Location = new System.Drawing.Point(688, 261);
            this.cb_Movimiento.Name = "cb_Movimiento";
            this.cb_Movimiento.Size = new System.Drawing.Size(187, 24);
            this.cb_Movimiento.TabIndex = 42;
            this.cb_Movimiento.Tag = "";
            this.cb_Movimiento.SelectedIndexChanged += new System.EventHandler(this.cb_Movimiento_SelectedIndexChanged);
            // 
            // txt_Descrip
            // 
            this.txt_Descrip.Location = new System.Drawing.Point(688, 214);
            this.txt_Descrip.Name = "txt_Descrip";
            this.txt_Descrip.Size = new System.Drawing.Size(187, 22);
            this.txt_Descrip.TabIndex = 41;
            this.txt_Descrip.Tag = "descripcion_movimiento";
            // 
            // txt_IDMov
            // 
            this.txt_IDMov.Location = new System.Drawing.Point(284, 212);
            this.txt_IDMov.Name = "txt_IDMov";
            this.txt_IDMov.Size = new System.Drawing.Size(187, 22);
            this.txt_IDMov.TabIndex = 39;
            this.txt_IDMov.Tag = "id_movimiento_inv";
            // 
            // dgv_MovimientoInv
            // 
            this.dgv_MovimientoInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MovimientoInv.Location = new System.Drawing.Point(49, 470);
            this.dgv_MovimientoInv.Name = "dgv_MovimientoInv";
            this.dgv_MovimientoInv.RowHeadersWidth = 51;
            this.dgv_MovimientoInv.RowTemplate.Height = 24;
            this.dgv_MovimientoInv.Size = new System.Drawing.Size(943, 150);
            this.dgv_MovimientoInv.TabIndex = 38;
            this.dgv_MovimientoInv.Tag = "tbl_movimiento_inv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label5.Location = new System.Drawing.Point(562, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(210, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(493, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo de Movimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(244, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(180, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cantidad:";
            // 
            // txt_CantidadMov
            // 
            this.txt_CantidadMov.Location = new System.Drawing.Point(284, 311);
            this.txt_CantidadMov.Name = "txt_CantidadMov";
            this.txt_CantidadMov.Size = new System.Drawing.Size(187, 22);
            this.txt_CantidadMov.TabIndex = 58;
            this.txt_CantidadMov.Tag = "cantidad_movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(361, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 59;
            this.label7.Text = "Producto:";
            // 
            // cb_Sucursal
            // 
            this.cb_Sucursal.FormattingEnabled = true;
            this.cb_Sucursal.Location = new System.Drawing.Point(688, 311);
            this.cb_Sucursal.Name = "cb_Sucursal";
            this.cb_Sucursal.Size = new System.Drawing.Size(187, 24);
            this.cb_Sucursal.TabIndex = 60;
            this.cb_Sucursal.Tag = "";
            this.cb_Sucursal.SelectedIndexChanged += new System.EventHandler(this.cb_Sucursal_SelectedIndexChanged);
            // 
            // cb_Producto
            // 
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(467, 377);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(187, 24);
            this.cb_Producto.TabIndex = 61;
            this.cb_Producto.Tag = "";
            this.cb_Producto.SelectedIndexChanged += new System.EventHandler(this.cb_Producto_SelectedIndexChanged);
            // 
            // txt_Movimiento
            // 
            this.txt_Movimiento.Location = new System.Drawing.Point(942, 377);
            this.txt_Movimiento.Name = "txt_Movimiento";
            this.txt_Movimiento.Size = new System.Drawing.Size(50, 22);
            this.txt_Movimiento.TabIndex = 62;
            this.txt_Movimiento.Tag = "tbl_movimientos_id_movimiento";
            // 
            // txt_Sucursal
            // 
            this.txt_Sucursal.Location = new System.Drawing.Point(942, 405);
            this.txt_Sucursal.Name = "txt_Sucursal";
            this.txt_Sucursal.Size = new System.Drawing.Size(50, 22);
            this.txt_Sucursal.TabIndex = 63;
            this.txt_Sucursal.Tag = "tbl_sucursales_id_sucursal";
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(942, 433);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(50, 22);
            this.txt_Producto.TabIndex = 64;
            this.txt_Producto.Tag = "tbl_Producto_cod_producto";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(15, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 65;
            // 
            // frmMovimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 639);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_Producto);
            this.Controls.Add(this.txt_Sucursal);
            this.Controls.Add(this.txt_Movimiento);
            this.Controls.Add(this.cb_Producto);
            this.Controls.Add(this.cb_Sucursal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CantidadMov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Movimiento);
            this.Controls.Add(this.txt_Descrip);
            this.Controls.Add(this.txt_IDMov);
            this.Controls.Add(this.dgv_MovimientoInv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmMovimientoInventario";
            this.Text = "frmMovimientoInventario";
            this.Load += new System.EventHandler(this.frmMovimientoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MovimientoInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Movimiento;
        private System.Windows.Forms.TextBox txt_Descrip;
        private System.Windows.Forms.TextBox txt_IDMov;
        private System.Windows.Forms.DataGridView dgv_MovimientoInv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CantidadMov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Sucursal;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.TextBox txt_Movimiento;
        private System.Windows.Forms.TextBox txt_Sucursal;
        private System.Windows.Forms.TextBox txt_Producto;
        private CapaVista.Navegador navegador1;
    }
}