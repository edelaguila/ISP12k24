﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_Mant_Proveedor : Form
    {
        public frm_Mant_Proveedor()
        {
            InitializeComponent();
            this.navegador1.config("tbl_proveedor", this, "8001");
        }
   
    }
}