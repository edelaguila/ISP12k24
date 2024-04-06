namespace CapaVistaERP.Mantenimientos
{
    partial class frm_Mant_TransProveedores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tipotrans = new System.Windows.Forms.ComboBox();
            this.cb_estadoprov = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idprov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Nomprov = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 282);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 265);
            this.dataGridView1.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_tipotrans);
            this.groupBox2.Controls.Add(this.cb_estadoprov);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_idprov);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Nomprov);
            this.groupBox2.Location = new System.Drawing.Point(14, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1025, 128);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // cb_tipotrans
            // 
            this.cb_tipotrans.FormattingEnabled = true;
            this.cb_tipotrans.Location = new System.Drawing.Point(616, 15);
            this.cb_tipotrans.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tipotrans.Name = "cb_tipotrans";
            this.cb_tipotrans.Size = new System.Drawing.Size(211, 24);
            this.cb_tipotrans.TabIndex = 28;
            this.cb_tipotrans.Tag = "tipo_transprov";
            this.cb_tipotrans.SelectedIndexChanged += new System.EventHandler(this.cb_tipotrans_SelectedIndexChanged);
            // 
            // cb_estadoprov
            // 
            this.cb_estadoprov.FormattingEnabled = true;
            this.cb_estadoprov.Location = new System.Drawing.Point(616, 47);
            this.cb_estadoprov.Margin = new System.Windows.Forms.Padding(4);
            this.cb_estadoprov.Name = "cb_estadoprov";
            this.cb_estadoprov.Size = new System.Drawing.Size(211, 24);
            this.cb_estadoprov.TabIndex = 27;
            this.cb_estadoprov.Tag = "estado_transprov";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(521, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id";
            // 
            // txt_idprov
            // 
            this.txt_idprov.Enabled = false;
            this.txt_idprov.Location = new System.Drawing.Point(203, 21);
            this.txt_idprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idprov.Name = "txt_idprov";
            this.txt_idprov.Size = new System.Drawing.Size(211, 22);
            this.txt_idprov.TabIndex = 17;
            this.txt_idprov.Tag = "id_transprov";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre";
            // 
            // txt_Nomprov
            // 
            this.txt_Nomprov.Location = new System.Drawing.Point(203, 51);
            this.txt_Nomprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nomprov.Name = "txt_Nomprov";
            this.txt_Nomprov.Size = new System.Drawing.Size(211, 22);
            this.txt_Nomprov.TabIndex = 1;
            this.txt_Nomprov.Tag = "nombre_transprov";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navegador1);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1025, 125);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(17, 21);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 0;
            // 
            // frm_Mant_TransProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Mant_TransProveedores";
            this.Text = "frm_Mant_TransProveedores";
            this.Load += new System.EventHandler(this.frm_Mant_TransProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_tipotrans;
        private System.Windows.Forms.ComboBox cb_estadoprov;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idprov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Nomprov;
        private System.Windows.Forms.GroupBox groupBox1;
        private CapaVista.Navegador navegador1;
    }
}