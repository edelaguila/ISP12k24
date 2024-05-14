
namespace CapaVistaERP.Procesos
{
    partial class GestionCotizaciones
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
            this.data_cotizaciones = new System.Windows.Forms.DataGridView();
            this.data_products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_cotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_products)).BeginInit();
            this.SuspendLayout();
            // 
            // data_cotizaciones
            // 
            this.data_cotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cotizaciones.Location = new System.Drawing.Point(12, 301);
            this.data_cotizaciones.Name = "data_cotizaciones";
            this.data_cotizaciones.ReadOnly = true;
            this.data_cotizaciones.RowHeadersVisible = false;
            this.data_cotizaciones.RowHeadersWidth = 51;
            this.data_cotizaciones.RowTemplate.Height = 24;
            this.data_cotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_cotizaciones.Size = new System.Drawing.Size(656, 392);
            this.data_cotizaciones.TabIndex = 149;
            this.data_cotizaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_cotizaciones_CellContentClick);
            this.data_cotizaciones.SelectionChanged += new System.EventHandler(this.data_cotizaciones_SelectionChanged);
            this.data_cotizaciones.Click += new System.EventHandler(this.data_cotizaciones_Click);
            this.data_cotizaciones.DoubleClick += new System.EventHandler(this.data_cotizaciones_DoubleClick);
            // 
            // data_products
            // 
            this.data_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_products.Location = new System.Drawing.Point(674, 301);
            this.data_products.Name = "data_products";
            this.data_products.ReadOnly = true;
            this.data_products.RowHeadersWidth = 51;
            this.data_products.RowTemplate.Height = 24;
            this.data_products.Size = new System.Drawing.Size(656, 392);
            this.data_products.TabIndex = 150;
            // 
            // GestionCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 726);
            this.Controls.Add(this.data_products);
            this.Controls.Add(this.data_cotizaciones);
            this.Name = "GestionCotizaciones";
            this.Text = "GestionCotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.data_cotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_cotizaciones;
        private System.Windows.Forms.DataGridView data_products;
    }
}