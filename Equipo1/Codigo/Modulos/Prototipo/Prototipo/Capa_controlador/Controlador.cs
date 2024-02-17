using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_PrototipoMenu;

namespace Controlador_PrototipoMenu
{
    public class Controlador
    {
        public Sentencias sn;

        public Controlador()
        {
            sn = new Sentencias();
        }

        public void CargarOpcionesGenero(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Masculino");
            combo.Items.Add("Femenino");
        }
        public void CargarOpcionesEstado(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Soltero");
            combo.Items.Add("Casado");
        }

        public void CargarOpcionesTez(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Clara");
            combo.Items.Add("Media");
            combo.Items.Add("Oscura");
            combo.Items.Add("Muy Oscura");
        }

        public void CargarOpcionesOjos(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Azul");
            combo.Items.Add("Verde");
            combo.Items.Add("Marrón");
            combo.Items.Add("Avellana");
            combo.Items.Add("Gris");
            combo.Items.Add("Negro");
        }
        public void CargarOpcionesOcupacion(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Estudiante");
            combo.Items.Add("Empleado/a");
            combo.Items.Add("Trabajador/a independiente");
            combo.Items.Add("Empresario/a");
            combo.Items.Add("Desempleado/a");
            combo.Items.Add("Jubilado/a");
            combo.Items.Add("Amo/a de casa");
            combo.Items.Add("Militar");
            combo.Items.Add("Funcionario/a público/a");
            combo.Items.Add("Profesional");
            combo.Items.Add("Artista");
            combo.Items.Add("Agricultor/a");
            combo.Items.Add("Otra");
        }

        public bool InsertarDocumento(int codigo, string numdoc, string nacionalidad, string genero, string estadocivil, string nombre, string Papellido, string Sappelido, string fechaNacimiento, string Capellido)
        {
            return sn.InsertarDocumento(codigo, numdoc, nacionalidad, genero, estadocivil, nombre, Papellido, Sappelido, fechaNacimiento, Capellido);
        }

        public bool InsertarDatosPersonales(string nombre, string Papellido, string Sappelido, string fechaNacimiento, string direccion, string celular, string telefono, string correo, string confcorreo, string altura, string tez, string ojos, string ocupacion, int codigo, string Capellido)
        {
            return sn.InsertarDatosPersonales(nombre, Papellido, Sappelido, fechaNacimiento, direccion, celular, telefono, correo, confcorreo, altura, tez, ojos, ocupacion, codigo, Capellido);
        }

    }
}
