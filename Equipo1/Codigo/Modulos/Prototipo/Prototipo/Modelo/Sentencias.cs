using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Modelo_PrototipoMenu
{
    //Para la reagendacion de citas
    public class Cita
    {
        public int Pk_id_cita { get; set; }
        public string cit_fecha { get; set; }
        public string cit_hora { get; set; }
        public string cit_dept { get; set; }
        public string cit_ciudad { get; set; }
        public int tbl_documento_Pk_num_dpi { get; set; }
        public int tbl_boleta_Pk_No_Boleta { get; set; }
        public int tbl_CGC_Pk_no_cgc { get; set; }
    }


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

        //Existencia de la cita a reagendar
        public Cita BuscarCita(int noBoleta, int noDocumento, int noCGC)
        {
            Cita citaEncontrada = null;

            using (OdbcConnection conn = con.connection())
            {
                try
                {
                    conn.Open();

                    string consulta = "SELECT Pk_id_cita, cit_fecha, cit_hora, cit_dept, cit_ciudad, tbl_boleta_Pk_No_Boleta, tbl_documento_Pk_num_dpi, tbl_CGC_Pk_no_cgc FROM tbl_cita WHERE tbl_boleta_Pk_No_Boleta = ? AND tbl_documento_Pk_num_dpi = ? AND tbl_CGC_Pk_no_cgc = ?";
                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@NoBoleta", noBoleta);
                        cmd.Parameters.AddWithValue("@NoDocumento", noDocumento);
                        cmd.Parameters.AddWithValue("@NoCGC", noCGC);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                citaEncontrada = new Cita
                                {
                                    Pk_id_cita = Convert.ToInt32(reader["Pk_id_cita"]),
                                    cit_fecha = reader["cit_fecha"].ToString(),
                                    cit_hora = reader["cit_hora"].ToString(),
                                    cit_dept = reader["cit_dept"].ToString(),
                                    cit_ciudad = reader["cit_ciudad"].ToString(),
                                    tbl_boleta_Pk_No_Boleta = Convert.ToInt32(reader["tbl_boleta_Pk_No_Boleta"]),
                                    tbl_documento_Pk_num_dpi = Convert.ToInt32(reader["tbl_documento_Pk_num_dpi"]),
                                    tbl_CGC_Pk_no_cgc = Convert.ToInt32(reader["tbl_CGC_Pk_no_cgc"])
                                };
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Cita no encontrada verificar datos: " + ex.Message);
                }
            }

            return citaEncontrada;
        }
        //Fin Existencia de la cita a reagendar

        //sentencias para generacion de boleta

        public List<string> llenarCombo(string columna1, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.connection());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna1].ToString();
                    datos.Add(ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.connection());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        public bool Guardar(string tabla, Dictionary<string, object> valores)
        {
            using (OdbcConnection conn = con.connection())
            {
                // Construir la consulta SQL para insertar datos
                string columnas = string.Join(", ", valores.Keys);
                string parametros = string.Join(", ", valores.Keys.Select(key => "?"));
                string consulta = $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})";

                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    // Agregar parámetros con sus valores correspondientes
                    foreach (var kvp in valores)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
