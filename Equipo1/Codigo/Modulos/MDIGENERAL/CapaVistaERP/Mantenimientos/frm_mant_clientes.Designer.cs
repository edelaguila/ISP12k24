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
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.txt_apellido_clientee = new System.Windows.Forms.TextBox();
            this.txt_direccion_cliente = new System.Windows.Forms.TextBox();
            this.txt_correo_cliente = new System.Windows.Forms.TextBox();
            this.txt_telefono_cliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idCliente.Location = new System.Drawing.Point(27, 126);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(200, 30);
            this.txt_idCliente.TabIndex = 0;
            this.txt_idCliente.Tag = "id_cliente";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.Location = new System.Drawing.Point(27, 198);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(200, 30);
            this.txt_nombre_cliente.TabIndex = 1;
            this.txt_nombre_cliente.Tag = "nombre_cl";
            // 
            // txt_apellido_clientee
            // 
            this.txt_apellido_clientee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_clientee.Location = new System.Drawing.Point(27, 271);
            this.txt_apellido_clientee.Name = "txt_apellido_clientee";
            this.txt_apellido_clientee.Size = new System.Drawing.Size(200, 30);
            this.txt_apellido_clientee.TabIndex = 2;
            this.txt_apellido_clientee.Tag = "apellido_cl";
            // 
            // txt_direccion_cliente
            // 
            this.txt_direccion_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_cliente.Location = new System.Drawing.Point(389, 126);
            this.txt_direccion_cliente.Name = "txt_direccion_cliente";
            this.txt_direccion_cliente.Size = new System.Drawing.Size(200, 30);
            this.txt_direccion_cliente.TabIndex = 3;
            this.txt_direccion_cliente.Tag = "direccion_cl";
            // 
            // txt_correo_cliente
            // 
            this.txt_correo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo_cliente.Location = new System.Drawing.Point(389, 198);
            this.txt_correo_cliente.Name = "txt_correo_cliente";
            this.txt_correo_cliente.Size = new System.Drawing.Size(200, 30);
            this.txt_correo_cliente.TabIndex = 4;
            this.txt_correo_cliente.Tag = "correo__cl";
            // 
            // txt_telefono_cliente
            // 
            this.txt_telefono_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_cliente.Location = new System.Drawing.Point(389, 271);
            this.txt_telefono_cliente.Name = "txt_telefono_cliente";
            this.txt_telefono_cliente.Size = new System.Drawing.Size(200, 30);
            this.txt_telefono_cliente.TabIndex = 5;
            this.txt_telefono_cliente.Tag = "telefono_cl";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 207);
            this.dataGridView1.TabIndex = 6;
            // 
            // frm_mant_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 605);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_telefono_cliente);
            this.Controls.Add(this.txt_correo_cliente);
            this.Controls.Add(this.txt_direccion_cliente);
            this.Controls.Add(this.txt_apellido_clientee);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.txt_idCliente);
            this.Name = "frm_mant_clientes";
            this.Text = "frm_mant_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idCliente;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.TextBox txt_apellido_clientee;
        private System.Windows.Forms.TextBox txt_direccion_cliente;
        private System.Windows.Forms.TextBox txt_correo_cliente;
        private System.Windows.Forms.TextBox txt_telefono_cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}