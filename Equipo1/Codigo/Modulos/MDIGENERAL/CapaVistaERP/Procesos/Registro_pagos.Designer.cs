namespace CapaVistaERP.Procesos
{
    partial class Registro_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_pagos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ayudas = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dt_datos = new System.Windows.Forms.DataGridView();
            this.cb_año = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_ayudas);
            this.panel1.Controls.Add(this.btn_reporte);
            this.panel1.Controls.Add(this.btn_refrescar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 101);
            this.panel1.TabIndex = 12;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Snow;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salir.Location = new System.Drawing.Point(372, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(84, 71);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
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
            this.btn_ayudas.Location = new System.Drawing.Point(282, 12);
            this.btn_ayudas.Name = "btn_ayudas";
            this.btn_ayudas.Size = new System.Drawing.Size(84, 71);
            this.btn_ayudas.TabIndex = 5;
            this.btn_ayudas.Text = "Ayuda";
            this.btn_ayudas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ayudas.UseVisualStyleBackColor = false;
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.ForeColor = System.Drawing.Color.Snow;
            this.btn_reporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_reporte.Image")));
            this.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_reporte.Location = new System.Drawing.Point(192, 12);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(84, 71);
            this.btn_reporte.TabIndex = 4;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click_1);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refrescar.ForeColor = System.Drawing.Color.Snow;
            this.btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.Image")));
            this.btn_refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refrescar.Location = new System.Drawing.Point(102, 12);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(84, 71);
            this.btn_refrescar.TabIndex = 3;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(113)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.Snow;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eliminar.Location = new System.Drawing.Point(12, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(84, 71);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // dt_datos
            // 
            this.dt_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_datos.Location = new System.Drawing.Point(12, 182);
            this.dt_datos.Name = "dt_datos";
            this.dt_datos.RowHeadersWidth = 51;
            this.dt_datos.RowTemplate.Height = 24;
            this.dt_datos.Size = new System.Drawing.Size(895, 384);
            this.dt_datos.TabIndex = 14;
            // 
            // cb_año
            // 
            this.cb_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_año.FormattingEnabled = true;
            this.cb_año.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.cb_año.Location = new System.Drawing.Point(82, 133);
            this.cb_año.Name = "cb_año";
            this.cb_año.Size = new System.Drawing.Size(139, 33);
            this.cb_año.TabIndex = 21;
            this.cb_año.Text = "Selecciona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Año:";
            // 
            // cb_filtro
            // 
            this.cb_filtro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual"});
            this.cb_filtro.Location = new System.Drawing.Point(384, 135);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(145, 31);
            this.cb_filtro.TabIndex = 19;
            this.cb_filtro.Text = "Selecciona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filtrar por:";
            // 
            // Registro_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 592);
            this.Controls.Add(this.cb_año);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_datos);
            this.Controls.Add(this.panel1);
            this.Name = "Registro_pagos";
            this.Text = "Registro_pagos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ayudas;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridView dt_datos;
        private System.Windows.Forms.ComboBox cb_año;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label label1;
    }
}