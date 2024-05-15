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
using CapaModelo_SisB.Libraries;
using CapaModelo_SisB.Templates;

namespace CapaVista_SisB
{
   
    public partial class frmHistorial : Form
    {
        Controlador cn = new Controlador();
        CapaControlador_SisB.Controlador ctrl;
        public int accId;
        public frmHistorial()
        {
            InitializeComponent();
            this.ctrl = new CapaControlador_SisB.Controlador();
            accId = Convert.ToInt32(Seguridad_Controlador.Controlador.GetHash(Seguridad_Controlador.Controlador.idUser));
            Cuenta account = this.ctrl.getCurrentAccount(accId);
            cargarDatos();
        }

        public void llenardatagridView()
        {
            int id_cuenta = Convert.ToInt32(cmb_auto.Text.Split('-')[1]);
            DataTable dt = cn.llenarHistorial("tbl_historial_transacciones",id_cuenta);
            dataGridView1.DataSource = dt;

        }

        public void llenarse(string tabla, string campo1, string campo2, int id)
        {

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;
            int ida = id;
            

            cmb_auto.ValueMember = "cue_numero";
            cmb_auto.DisplayMember = "cue_usuario";
            string[] items = cn.items(tabla, campo1, campo2, id);
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cmb_auto.Items.Add(items[i]);
                    }
                }

            }

            var dt2 = cn.enviar(tabla, campo1, campo2, id);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]) + " - " + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + " - " + Convert.ToString(row[campo1]));


            }

            cmb_auto.AutoCompleteCustomSource = coleccion;
            cmb_auto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_auto.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        void cargarDatos()
        {
            llenarse("tbl_cuenta", "cue_numero", "cue_id", accId);
        }

        private void FHbutton1_Click(object sender, EventArgs e)
        {

            llenardatagridView();
        }
    }
}
