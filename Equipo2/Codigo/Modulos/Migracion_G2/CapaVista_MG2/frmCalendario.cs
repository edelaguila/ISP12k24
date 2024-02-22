using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_MG2.Templates;

namespace CapaVista_MG2
{
    public partial class frmCalendario : Form
    {
        public CapaControlador_MG2.Controlador ctrl;
        public Persona mipersona;
        public frmCalendario()
        {
            this.mipersona = new Persona();
            this.ctrl = new CapaControlador_MG2.Controlador();
            InitializeComponent();
        }

        public void setData(Persona per)
        {
            this.mipersona = per;
        }


        public int getDays(int m)
        {
            return DateTime.DaysInMonth(2024, m);
        }

        public void fillLayout(int days, int m)
        {
            this.frmCalendar.Controls.Clear();
            for (int i = 1; i <= days; i++)
            {
                frmDia frm = new frmDia();
                DateTime date = new DateTime(2024, m, i);
                string _day = date.ToString("dddd");
                frm.lbl_numero.Text = i.ToString();
                frm.lbl_dia.Text = _day.ToString();
                frm.setData(this.mipersona);
                bool isAvailable = this.ctrl.dateIsAvailable("2024-" + m.ToString() + "-" + i.ToString());
                Color _color = isAvailable ? Color.Green : Color.Red;
                frm.panel_enable.BackColor = _color;
                this.frmCalendar.Controls.Add(frm);
            }
        }

        private void cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = cmb_month.SelectedIndex + 1;
            this.fillLayout(this.getDays(month), month);
        }
    }
}




