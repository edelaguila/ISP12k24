using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVista_SisB
{
    public partial class frmMoneda : Form
    {
        // Código de configuración de Navegador
        public frmMoneda()
        {
            InitializeComponent();
            // Conexión a tabla
            navegador1.config("tbl_moneda", this, "8003");
        }
    }
}
