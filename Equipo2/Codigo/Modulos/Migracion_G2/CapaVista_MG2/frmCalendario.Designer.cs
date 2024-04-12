
namespace CapaVista_MG2
{
    partial class frmCalendario
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
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.frmCalendar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cmb_month
            // 
            this.cmb_month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_month.Location = new System.Drawing.Point(38, 50);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(158, 21);
            this.cmb_month.TabIndex = 0;
            this.cmb_month.Text = "Seleccione un mes";
            this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.cmb_month_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mes:";
            // 
            // frmCalendar
            // 
            this.frmCalendar.AutoScroll = true;
            this.frmCalendar.Location = new System.Drawing.Point(39, 94);
            this.frmCalendar.Name = "frmCalendar";
            this.frmCalendar.Size = new System.Drawing.Size(767, 331);
            this.frmCalendar.TabIndex = 6;
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 460);
            this.Controls.Add(this.frmCalendar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_month);
            this.Name = "frmCalendario";
            this.Text = "frmCalendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel frmCalendar;
    }
}