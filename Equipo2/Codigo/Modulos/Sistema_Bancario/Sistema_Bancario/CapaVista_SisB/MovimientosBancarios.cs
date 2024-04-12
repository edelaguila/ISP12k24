using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_SisB;

namespace CapaVista_SisB
{
    public partial class MovimientosBancarios : Form
    {
         Controlador cn = new Controlador();
         Controlador con = new Controlador();
        string mov = "tbl_movimientosBancarios";
        public MovimientosBancarios()
        {
            InitializeComponent();
            actualizardatagridView();

           /* dgv_vistaTransacciones.Columns[0].HeaderText = "ID";
            dgv_vistaTransacciones.Columns[1].HeaderText = "Valor";
            dgv_vistaTransacciones.Columns[2].HeaderText = "Descripcion";
            dgv_vistaTransacciones.Columns[3].HeaderText = "Cuenta a debitar";
            dgv_vistaTransacciones.Columns[4].HeaderText = "Cuenta a acreditar";
            dgv_vistaTransacciones.Columns[5].HeaderText = "Transaccion";
            dgv_vistaTransacciones.Columns[6].HeaderText = "Valor";
            dgv_vistaTransacciones.Columns[7].HeaderText = "Estatus";
            dgv_vistaTransacciones.Columns[8].HeaderText = "Fecha de ingreso";*/
        }

        public void actualizardatagridView()
        {
            DataTable dt = cn.llenarTbl(mov);
            dgv_vistaTransacciones.DataSource = dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Mov_bancarios_Load(object sender, EventArgs e)
        {

            DataTable tipoTrans = cn.ObtenerTipoDeTransacciones();
            if (tipoTrans != null)
            {
                foreach (DataRow row in tipoTrans.Rows)
                {
                    cb_tipoTrans.Items.Add(row["movtm_transacciones_existentes"].ToString());
                }
            }

            DataTable vtrnas = cn.valorTrans();
            if (vtrnas != null)
            {
                foreach (DataRow row in vtrnas.Rows)
                {
                    cb_tipoTrans.Items.Add(row["movtm_valor_transaccion"].ToString());
                }
            }

        }




    }
}
