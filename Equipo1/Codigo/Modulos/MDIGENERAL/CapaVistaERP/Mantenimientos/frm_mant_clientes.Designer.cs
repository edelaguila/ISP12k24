namespace CapaVistaERP.Mantenimientos
{
    partial class frm_mant_clientes
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
            this.id_cliente = new System.Windows.Forms.TextBox();
            this.nombre_cl = new System.Windows.Forms.TextBox();
            this.apellido_cl = new System.Windows.Forms.TextBox();
            this.direccion_cl = new System.Windows.Forms.TextBox();
            this.correo_cl = new System.Windows.Forms.TextBox();
            this.telefono_cl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_cliente
            // 
            this.id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.Location = new System.Drawing.Point(179, 126);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(200, 30);
            this.id_cliente.TabIndex = 0;
            this.id_cliente.Tag = "id_cliente";
            // 
            // nombre_cl
            // 
            this.nombre_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_cl.Location = new System.Drawing.Point(179, 198);
            this.nombre_cl.Name = "nombre_cl";
            this.nombre_cl.Size = new System.Drawing.Size(200, 30);
            this.nombre_cl.TabIndex = 1;
            this.nombre_cl.Tag = "nombre_cl";
            // 
            // apellido_cl
            // 
            this.apellido_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_cl.Location = new System.Drawing.Point(179, 271);
            this.apellido_cl.Name = "apellido_cl";
            this.apellido_cl.Size = new System.Drawing.Size(200, 30);
            this.apellido_cl.TabIndex = 2;
            this.apellido_cl.Tag = "apellido_cl";
            // 
            // direccion_cl
            // 
            this.direccion_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_cl.Location = new System.Drawing.Point(541, 126);
            this.direccion_cl.Name = "direccion_cl";
            this.direccion_cl.Size = new System.Drawing.Size(200, 30);
            this.direccion_cl.TabIndex = 3;
            this.direccion_cl.Tag = "direccion_cl";
            // 
            // correo_cl
            // 
            this.correo_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_cl.Location = new System.Drawing.Point(541, 198);
            this.correo_cl.Name = "correo_cl";
            this.correo_cl.Size = new System.Drawing.Size(200, 30);
            this.correo_cl.TabIndex = 4;
            this.correo_cl.Tag = "correo_cl";
            // 
            // telefono_cl
            // 
            this.telefono_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_cl.Location = new System.Drawing.Point(541, 271);
            this.telefono_cl.Name = "telefono_cl";
            this.telefono_cl.Size = new System.Drawing.Size(200, 30);
            this.telefono_cl.TabIndex = 5;
            this.telefono_cl.Tag = "telefono_cl";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 207);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Tag = "tbl_clientes";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(1, 2);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1011, 100);
            this.navegador1.TabIndex = 7;
            // 
            // frm_mant_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 605);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.telefono_cl);
            this.Controls.Add(this.correo_cl);
            this.Controls.Add(this.direccion_cl);
            this.Controls.Add(this.apellido_cl);
            this.Controls.Add(this.nombre_cl);
            this.Controls.Add(this.id_cliente);
            this.Name = "frm_mant_clientes";
            this.Text = "frm_mant_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_cliente;
        private System.Windows.Forms.TextBox nombre_cl;
        private System.Windows.Forms.TextBox apellido_cl;
        private System.Windows.Forms.TextBox direccion_cl;
        private System.Windows.Forms.TextBox correo_cl;
        private System.Windows.Forms.TextBox telefono_cl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CapaVista.Navegador navegador1;
    }
}