
namespace CapaVistaERP.Mantenimientos
{
    partial class frmSucursales
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Sucursal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IDSucursal = new System.Windows.Forms.TextBox();
            this.txt_NombreSucursal = new System.Windows.Forms.TextBox();
            this.txt_DireccionSuc = new System.Windows.Forms.TextBox();
            this.txt_TelefonoSuc = new System.Windows.Forms.TextBox();
            this.txt_CorreoSuc = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(323, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "REGISTRO DE SUCURSALES";
            // 
            // dgv_Sucursal
            // 
            this.dgv_Sucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sucursal.Location = new System.Drawing.Point(12, 332);
            this.dgv_Sucursal.Name = "dgv_Sucursal";
            this.dgv_Sucursal.RowHeadersWidth = 51;
            this.dgv_Sucursal.RowTemplate.Height = 24;
            this.dgv_Sucursal.Size = new System.Drawing.Size(1005, 177);
            this.dgv_Sucursal.TabIndex = 46;
            this.dgv_Sucursal.Tag = "tbl_sucursales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(728, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Correo:";
            // 
            // txt_IDSucursal
            // 
            this.txt_IDSucursal.Location = new System.Drawing.Point(128, 214);
            this.txt_IDSucursal.Name = "txt_IDSucursal";
            this.txt_IDSucursal.Size = new System.Drawing.Size(180, 22);
            this.txt_IDSucursal.TabIndex = 52;
            this.txt_IDSucursal.Tag = "id_sucursal";
            // 
            // txt_NombreSucursal
            // 
            this.txt_NombreSucursal.Location = new System.Drawing.Point(128, 267);
            this.txt_NombreSucursal.Name = "txt_NombreSucursal";
            this.txt_NombreSucursal.Size = new System.Drawing.Size(180, 22);
            this.txt_NombreSucursal.TabIndex = 53;
            this.txt_NombreSucursal.Tag = "nombre_sucursal";
            // 
            // txt_DireccionSuc
            // 
            this.txt_DireccionSuc.Location = new System.Drawing.Point(489, 212);
            this.txt_DireccionSuc.Name = "txt_DireccionSuc";
            this.txt_DireccionSuc.Size = new System.Drawing.Size(180, 22);
            this.txt_DireccionSuc.TabIndex = 54;
            this.txt_DireccionSuc.Tag = "direccion_sucursal";
            // 
            // txt_TelefonoSuc
            // 
            this.txt_TelefonoSuc.Location = new System.Drawing.Point(489, 267);
            this.txt_TelefonoSuc.Name = "txt_TelefonoSuc";
            this.txt_TelefonoSuc.Size = new System.Drawing.Size(180, 22);
            this.txt_TelefonoSuc.TabIndex = 55;
            this.txt_TelefonoSuc.Tag = "telefono_sucursal";
            // 
            // txt_CorreoSuc
            // 
            this.txt_CorreoSuc.Location = new System.Drawing.Point(799, 245);
            this.txt_CorreoSuc.Name = "txt_CorreoSuc";
            this.txt_CorreoSuc.Size = new System.Drawing.Size(180, 22);
            this.txt_CorreoSuc.TabIndex = 56;
            this.txt_CorreoSuc.Tag = "correo_sucursal";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(15, 26);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1001, 96);
            this.navegador1.TabIndex = 57;
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 521);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_CorreoSuc);
            this.Controls.Add(this.txt_TelefonoSuc);
            this.Controls.Add(this.txt_DireccionSuc);
            this.Controls.Add(this.txt_NombreSucursal);
            this.Controls.Add(this.txt_IDSucursal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Sucursal);
            this.Controls.Add(this.label6);
            this.Name = "frmSucursales";
            this.Text = "frmSucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IDSucursal;
        private System.Windows.Forms.TextBox txt_NombreSucursal;
        private System.Windows.Forms.TextBox txt_DireccionSuc;
        private System.Windows.Forms.TextBox txt_TelefonoSuc;
        private System.Windows.Forms.TextBox txt_CorreoSuc;
        private CapaVista.Navegador navegador1;
    }
}