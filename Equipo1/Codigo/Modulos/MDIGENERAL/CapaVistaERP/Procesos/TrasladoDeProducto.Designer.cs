
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_entregador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_solicitante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fechaTraslado = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_OrigenSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_destinoSucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_traslado = new System.Windows.Forms.Button();
            this.dgv_traslado = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantTras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_NombreProd = new System.Windows.Forms.ComboBox();
            this.txt_CantidadTraslado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_entregador);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_solicitante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_fechaTraslado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_OrigenSucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_destinoSucursal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 325);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Traslado";
            // 
            // txt_entregador
            // 
            this.txt_entregador.Location = new System.Drawing.Point(335, 142);
            this.txt_entregador.Name = "txt_entregador";
            this.txt_entregador.Size = new System.Drawing.Size(209, 26);
            this.txt_entregador.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Entregado por";
            // 
            // txt_solicitante
            // 
            this.txt_solicitante.Location = new System.Drawing.Point(335, 89);
            this.txt_solicitante.Name = "txt_solicitante";
            this.txt_solicitante.Size = new System.Drawing.Size(209, 26);
            this.txt_solicitante.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Solicitado por";
            // 
            // dtp_fechaTraslado
            // 
            this.dtp_fechaTraslado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaTraslado.Location = new System.Drawing.Point(335, 41);
            this.dtp_fechaTraslado.Name = "dtp_fechaTraslado";
            this.dtp_fechaTraslado.Size = new System.Drawing.Size(156, 26);
            this.dtp_fechaTraslado.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // cb_OrigenSucursal
            // 
            this.cb_OrigenSucursal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cb_OrigenSucursal.FormattingEnabled = true;
            this.cb_OrigenSucursal.Location = new System.Drawing.Point(335, 193);
            this.cb_OrigenSucursal.Name = "cb_OrigenSucursal";
            this.cb_OrigenSucursal.Size = new System.Drawing.Size(209, 28);
            this.cb_OrigenSucursal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sucursal Origen";
            // 
            // cb_destinoSucursal
            // 
            this.cb_destinoSucursal.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cb_destinoSucursal.FormattingEnabled = true;
            this.cb_destinoSucursal.Location = new System.Drawing.Point(335, 255);
            this.cb_destinoSucursal.Name = "cb_destinoSucursal";
            this.cb_destinoSucursal.Size = new System.Drawing.Size(209, 28);
            this.cb_destinoSucursal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sucursal Destino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.btn_traslado);
            this.groupBox2.Controls.Add(this.dgv_traslado);
            this.groupBox2.Controls.Add(this.cb_NombreProd);
            this.groupBox2.Controls.Add(this.txt_CantidadTraslado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox2.Location = new System.Drawing.Point(18, 344);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(797, 305);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto a Trasladar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(677, 170);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(96, 31);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(677, 106);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(96, 31);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // btn_traslado
            // 
            this.btn_traslado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btn_traslado.Location = new System.Drawing.Point(677, 231);
            this.btn_traslado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_traslado.Name = "btn_traslado";
            this.btn_traslado.Size = new System.Drawing.Size(96, 54);
            this.btn_traslado.TabIndex = 60;
            this.btn_traslado.Text = "Realizar Traslado";
            this.btn_traslado.UseVisualStyleBackColor = true;
            this.btn_traslado.Click += new System.EventHandler(this.btn_traslado_Click);
            // 
            // dgv_traslado
            // 
            this.dgv_traslado.AllowUserToAddRows = false;
            this.dgv_traslado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_traslado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_traslado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_traslado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.nombreProd,
            this.cantTras,
            this.IdOrigen,
            this.IdDestino});
            this.dgv_traslado.Location = new System.Drawing.Point(29, 106);
            this.dgv_traslado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_traslado.Name = "dgv_traslado";
            this.dgv_traslado.ReadOnly = true;
            this.dgv_traslado.RowHeadersVisible = false;
            this.dgv_traslado.RowHeadersWidth = 51;
            this.dgv_traslado.RowTemplate.Height = 24;
            this.dgv_traslado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_traslado.Size = new System.Drawing.Size(625, 180);
            this.dgv_traslado.TabIndex = 12;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.MinimumWidth = 6;
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.ReadOnly = true;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "Nombre_Producto";
            this.nombreProd.MinimumWidth = 6;
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            // 
            // cantTras
            // 
            this.cantTras.HeaderText = "Cantidad_Traslado";
            this.cantTras.MinimumWidth = 6;
            this.cantTras.Name = "cantTras";
            this.cantTras.ReadOnly = true;
            // 
            // IdOrigen
            // 
            this.IdOrigen.HeaderText = "Origen";
            this.IdOrigen.MinimumWidth = 6;
            this.IdOrigen.Name = "IdOrigen";
            this.IdOrigen.ReadOnly = true;
            // 
            // IdDestino
            // 
            this.IdDestino.HeaderText = "Destino";
            this.IdDestino.MinimumWidth = 6;
            this.IdDestino.Name = "IdDestino";
            this.IdDestino.ReadOnly = true;
            // 
            // cb_NombreProd
            // 
            this.cb_NombreProd.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cb_NombreProd.FormattingEnabled = true;
            this.cb_NombreProd.Location = new System.Drawing.Point(144, 50);
            this.cb_NombreProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_NombreProd.Name = "cb_NombreProd";
            this.cb_NombreProd.Size = new System.Drawing.Size(163, 28);
            this.cb_NombreProd.TabIndex = 11;
            // 
            // txt_CantidadTraslado
            // 
            this.txt_CantidadTraslado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txt_CantidadTraslado.Location = new System.Drawing.Point(528, 54);
            this.txt_CantidadTraslado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CantidadTraslado.Name = "txt_CantidadTraslado";
            this.txt_CantidadTraslado.Size = new System.Drawing.Size(127, 26);
            this.txt_CantidadTraslado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(340, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad a Trasladar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(35, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Producto";
            // 
            // TrasladoDeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrasladoDeProducto";
            this.Text = "TrasladoDeProducto";
            this.Load += new System.EventHandler(this.TrasladoDeProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_traslado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_entregador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_solicitante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fechaTraslado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_OrigenSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_destinoSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_traslado;
        private System.Windows.Forms.DataGridView dgv_traslado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantTras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDestino;
        private System.Windows.Forms.ComboBox cb_NombreProd;
        private System.Windows.Forms.TextBox txt_CantidadTraslado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}