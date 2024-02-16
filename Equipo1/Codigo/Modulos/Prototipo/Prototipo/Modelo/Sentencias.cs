using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PrototipoMenu
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        public bool InsertarDocumento(int codigo, string numdoc, string nacionalidad, string genero, string estadocivil, string nombre, string Papellido, string Sappelido, string fechaNacimiento, string Capellido)
        {
            string insertQueryDocumento = getQueryDocumento(codigo, numdoc, nacionalidad, genero, estadocivil, nombre, Papellido, Sappelido, fechaNacimiento, Capellido);
            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryDocumento, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryDocumento(int codigo, string numdoc, string nacionalidad, string genero, string estadocivil, string nombre, string Papellido, string Sappelido, string fechaNacimiento, string Capellido)
        {
            string sql = "INSERT INTO tbl_documento(Pk_num_dpi,doc_dpi,doc_nacionalidad,doc_genero,doc_estadoCivil,doc_nombres,doc_primerapellido,doc_segundoapellido,doc_fechanacimiento,doc_casadoapellido)VALUES('" + codigo + "', '" + numdoc + "', '" + nacionalidad + "', '" + genero + "', '" + estadocivil + "', '" + nombre + "', '" + Papellido + "', '" + Sappelido + "', '" + fechaNacimiento + "', '" + Capellido + "')";
            return sql;
        }

        public bool InsertarDatosPersonales(string nombre, string Papellido, string Sappelido, string fechaNacimiento, string direccion, string celular, string telefono, string correo, string confcorreo, string altura, string tez, string ojos, string ocupacion, int codigo, string Capellido)
        {
            string insertQueryDatosPersonales = getQueryDatosPersonales(nombre, Papellido, Sappelido, fechaNacimiento, direccion, celular, telefono, correo, confcorreo, altura, tez, ojos, ocupacion, codigo, Capellido);
            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryDatosPersonales, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryDatosPersonales(string nombre, string Papellido, string Sappelido, string fechaNacimiento, string direccion, string celular, string telefono, string correo, string confcorreo, string altura, string tez, string ojos, string ocupacion, int codigo, string Capellido)
        {
            string sql = "INSERT INTO tbl_datospersonales(Pk_id,dp_nombre,dp_primerapellido,dp_segundoapellido,dp_fechanac,dp_dirResidencia,dp_celular,dp_telefono,dp_correo,dp_correoconfir,dp_alturacm,dp_tez,dp_ojos,dp_ocupacion,tbl_documento_Pk_num_dpi,dp_casadoapellido)VALUES(default,'" + nombre + "', '" + Papellido + "', '" + Sappelido + "', '" + fechaNacimiento + "', '" + direccion + "', '" + celular + "', '" + telefono + "', '" + correo + "', '" + confcorreo + "', '" + altura + "', '" + tez + "', '" + ojos + "', '" + ocupacion + "', '" + codigo + "', '" + Capellido + "')";
            return sql;
        }


    }
}
