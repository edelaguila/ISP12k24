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
    public partial class Mantenimiento_Estado : Form
    {
        //codigo de configuracion al navegador
        public Mantenimiento_Estado()
        {
            InitializeComponent();
            //conexion a la tabla
            navegador1.config("tbl_estados", this, "8003");
        }
    }
}
