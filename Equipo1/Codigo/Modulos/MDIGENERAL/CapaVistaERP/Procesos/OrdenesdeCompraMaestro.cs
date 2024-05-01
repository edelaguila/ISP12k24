using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Procesos
{
    public partial class OrdenesdeCompraMaestro : Form
    {
        private string id = "";
        private string nombre = "";
        private string domicilio = "";
        private string telefono = "";
        public OrdenesdeCompraMaestro()
        {
            InitializeComponent();
        }

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            OrdenesdeCompra OrdenesdeCompra = new OrdenesdeCompra(id, nombre, domicilio, telefono);
            OrdenesdeCompra.Show();
        }
    }
}
