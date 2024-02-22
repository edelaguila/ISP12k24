using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class DatosBoleta : Form
    {
        public DatosBoleta()
        {
            InitializeComponent();
        }

        private void btnvalidarboleta_Click(object sender, EventArgs e)
        {
            frmDatosPersonales frmDatosPersonales = new frmDatosPersonales();
            frmDatosPersonales.ShowDialog();

        }
    }
}
