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
using System.Data.Odbc;
namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_mant_agregar_cuenta : Form
    {
        Controlador cn = new Controlador();
        public frm_mant_agregar_cuenta()
        {
            InitializeComponent();
            this.navegador1.config("tbl_mantenimientos_agregar_cuenta", this, "8040");
        }

        private void frm_mant_agregar_cuenta_Load(object sender, EventArgs e)
        {

            // Establece la cadena de conexión a tu base de datos ODBC
            Controlador cn = new Controlador();

            // Obtener los datos de la tabla de cuentas
            DataTable tablaCuenta = cn.ObtenerCuentas();

            // Obtener los datos de la tabla de bancos
            DataTable tablaBancos = cn.ObtenerBancos();

            // Obtener los datos de la tabla de moneda de banco
            //  DataTable tablaMoneda = cn.ObtenerMonedaBanco();

            DataTable tiposMoneda = cn.ObtenerTiposMoneda();
            if (tiposMoneda != null)
            {
                foreach (DataRow row in tiposMoneda.Rows)
                {
                    cb_tipoMoneda.Items.Add(row["mon_nomMoneda"].ToString());
                }
            }


            DataTable Bancos = cn.ObtenerBancos();
            if (Bancos != null)
            {
                foreach (DataRow row in Bancos.Rows)
                {
                    cb_Banco.Items.Add(row["manag_nombre_banco"].ToString());
                }
            }

            DataTable tcuenta = cn.ObtenerTipoCuenta();
            if (tcuenta != null)
            {
                foreach (DataRow row in tcuenta.Rows)
                {
                    cb_tipocuenta.Items.Add(row["movtm_transacciones_existentes"].ToString());
                }
            }




        }

        private void cb_tipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoMoneda.SelectedItem != null)
            {
                string tipoMonedaSeleccionada = cb_tipoMoneda.SelectedItem.ToString();
                txt_tipo_mon.Text = tipoMonedaSeleccionada; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void cb_Banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Banco.SelectedItem != null)
            {
                string bancoSeleccionado = cb_Banco.SelectedItem.ToString();
                txt_sect_banco.Text = bancoSeleccionado; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void cb_tipocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipocuenta.SelectedItem != null)
            {
                string bancoSeleccionado = cb_tipocuenta.SelectedItem.ToString();
                txt_tipocuenta.Text = bancoSeleccionado; // Muestra la selección en el TextBox txt_tipo_mon
            }
        }

        private void txt_tipo_moneda_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
