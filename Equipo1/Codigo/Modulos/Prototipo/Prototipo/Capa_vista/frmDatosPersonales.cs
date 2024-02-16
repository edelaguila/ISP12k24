using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;

namespace Vista_PrototipoMenu
{
    public partial class frmDatosPersonales : Form
    {
        Controlador controller = new Controlador();
        int codigo = 7;
        public frmDatosPersonales()
        {
            InitializeComponent();
            controller.CargarOpcionesGenero(cmb_genero);
            controller.CargarOpcionesEstado(cmb_estadocivil);
            controller.CargarOpcionesTez(cmb_tez);
            controller.CargarOpcionesOjos(cmb_ojos);
            controller.CargarOpcionesOcupacion(cmb_ocupacion);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombres.Text;
            string Papellido = txt_primera.Text;
            string Sappelido = txt_segundoa.Text;
            string Capellido = txt_apecasado.Text;
            DateTime fechaNacimiento_a = dtp_nacimiento.Value;
            string fechaNacimiento = fechaNacimiento_a.ToString("yyyy-MM-dd");
            string tipodo = txt_tipodoc.Text;
            string numdoc = txt_numdoc.Text;
            string nacionalidad = txt_nacionalidad.Text;
            string genero = cmb_genero.Text;
            string estadocivil = cmb_estadocivil.Text;
            string direccion = txt_direccion.Text;
            string celular = txt_celular.Text;
            string telefono = txt_telefono.Text;
            string correo = txt_correo.Text;
            string confcorreo = txt_confcorreo.Text;
            string altura = txt_altura.Text;
            string tez = cmb_tez.Text;
            string ojos = cmb_ojos.Text;
            string ocupacion = cmb_ocupacion.Text;

            if (controller.InsertarDocumento(codigo, numdoc, nacionalidad, genero, estadocivil, nombre, Papellido, Sappelido, fechaNacimiento, Capellido))
            {
                MessageBox.Show("Datos personales ingresados correctamente");
                controller.InsertarDatosPersonales(nombre, Papellido, Sappelido, fechaNacimiento, direccion, celular, telefono, correo, confcorreo, altura, tez, ojos, ocupacion, codigo, Capellido);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            //string tabla = "tbl_ordenescompra";
            //string campoid = "ord_id";
            //int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            //txt_numeroorden.Text = ultimoNumeroOrden.ToString();
            txt_nombres.Clear();
            txt_primera.Clear();
            txt_segundoa.Clear();
            txt_apecasado.Clear();
            dtp_nacimiento.Value = DateTime.Now; // Restablece la fecha actual
            txt_numdoc.Clear();
            txt_nacionalidad.Clear();
            cmb_genero.SelectedIndex = -1;
            cmb_estadocivil.SelectedIndex = -1;
            txt_direccion.Clear();
            txt_celular.Clear();
            txt_telefono.Clear();
            txt_correo.Clear();
            txt_confcorreo.Clear();
            txt_altura.Clear();
            cmb_tez.SelectedIndex = -1;
            cmb_ojos.SelectedIndex = -1;
            cmb_ocupacion.SelectedIndex = -1;
        }
    }
}
