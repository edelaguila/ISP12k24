using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_SisB
{
    public partial class frmRetiro : Form
    {
        public frmRetiro()
        {
            InitializeComponent();
            //Limpiando los textbox cuando cargue el form
            textBox3.Clear();
            txt_cuenta.Clear();
        }

        private void btn_genCodigo_Click(object sender, EventArgs e)
        {
            //codigo escrito por Luis Franco
            if (txt_cuenta.Text != "" && textBox3.Text != "")
            {

                DialogResult result = MessageBox.Show("¿Desea generar un código de seguridad?", "Generar Código", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    Random rnd = new Random();
                    int codigo = rnd.Next(100000000, 999999999);


                    lbl_codigoSeguridad.Text = codigo.ToString();

                    // Limpiar los textbox
                    txt_cuenta.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el código.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //codigo escrito por Luis Franco
        private void VerificarCampos()
        {
            if (textBox3.Text != "" && txt_cuenta.Text != "")
            {
                btn_genCodigo.Enabled = true;
            }
            else
            {
                btn_genCodigo.Enabled = false;
            }
        }

        private void txt_cuenta_TextChanged(object sender, EventArgs e)
        {
            //codigo escrito por Luis Franco
            VerificarCampos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //codigo escrito por Luis Franco
            VerificarCampos();
        }
    }
}
