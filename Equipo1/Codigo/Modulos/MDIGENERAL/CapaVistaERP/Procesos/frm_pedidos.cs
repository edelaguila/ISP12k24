using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;

namespace CapaVistaERP.Procesos
{
    public partial class frm_pedidos : Form

    {
        Controlador cn = new Controlador();
        public frm_pedidos()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";

            DateTime fechaSeleccionada = dateTimePicker1.Value;
            DateTime nuevaFecha = fechaSeleccionada.AddDays(15);
            dateTimePicker2.Value = nuevaFecha;
        }

        private void frm_pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
        }
    }
}

    

