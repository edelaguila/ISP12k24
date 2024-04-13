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
            string connectionString = "Dsn=HotelSConexion";

            // Define la consulta SQL para cada tabla
            string queryCuenta = "SELECT * FROM tbl_mantenimientos_agregar_cuenta";
            string queryBancos = "SELECT * FROM tbl_mantenimientos_agregar_bancos";
            string queryMoneda = "SELECT * FROM tbl_monedabanco";

            // Crea un DataTable para cada tabla
            DataTable tablaCuenta = new DataTable();
            DataTable tablaBancos = new DataTable();
            DataTable tablaMoneda = new DataTable();

            // Crea una conexión OdbcConnection
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                // Abre la conexión
                connection.Open();

                // Crea un OdbcDataAdapter para cada consulta y llena el DataTable correspondiente
                using (OdbcDataAdapter adapterCuenta = new OdbcDataAdapter(queryCuenta, connection))
                using (OdbcDataAdapter adapterBancos = new OdbcDataAdapter(queryBancos, connection))
                using (OdbcDataAdapter adapterMoneda = new OdbcDataAdapter(queryMoneda, connection))
                {
                    adapterCuenta.Fill(tablaCuenta);
                    adapterBancos.Fill(tablaBancos);
                    adapterMoneda.Fill(tablaMoneda);
                }
            }



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
                cb_tipoMoneda.Text = tipoMonedaSeleccionada; // Muestra la selección en el TextBox txt_tipo_mon
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
    }
}
