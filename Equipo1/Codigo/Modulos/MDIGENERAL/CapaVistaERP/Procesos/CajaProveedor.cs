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
    public partial class CajaProveedor : Form
    {
        private Controlador cn;
        string tabla1 = "tbl_facturaxpagar";
        // private MovimientoProveedores MovimientoProveedorescaja;
        public CajaProveedor()
        {
            InitializeComponent();
            cn = new Controlador();
            tabla();
           // MovimientoProveedorescaja = movimientoProveedorescaja;
        }

        public void tabla()
        {
            DataTable dt = cn.llenarTablas(tabla1);
            dgv_pagoproveedor.DataSource = dt;
        }
    }
}
