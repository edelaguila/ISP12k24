using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using CapaModelo_SisB.Templates;


namespace CapaModelo_SisB
{
    public class Sentencias
    {

        public Conexion con;
        private static string baseDatos = "";
        public Sentencias()
        {
            this.con = new Conexion();
            this.con.myconn.Open();
            baseDatos = this.con.myconn.Database;
            this.con.myconn.Close();
        }
        public string[] llenarCmb(string tabla, string campo1, string campo2, int id)
        {
            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where cue_usuario =" + id + ";";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.connection());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
            return Campos;
        }

        /// Modelo 2 //

        public DataTable obtener(string tabla, string campo1, string campo2, int id)
        {

            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where cue_usuario =" + id + ";";

            OdbcCommand command = new OdbcCommand(sql, con.connection());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {

            this.con.myconn.Open();
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.myconn);
            //this.con.myconn.Open();
            return dataTable;
        }
        public DataTable llenarHistorial(string tabla, int id)
        {
            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    string sql = " SELECT * FROM " + tabla + " where htr_cuenta = " + id + " ;";
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);
                    return table;
                }
                else
                {
                    return null;
                }
            }
        }




        public OdbcDataReader getByParam<T>(string param, string secondParam, string table, int mode = 0, T reference = default, T secondRef = default)
        {
            this.con.myconn.Open();
            string[] sql = {
            "select * from "+table,
            "select * from "+table+" where "+param+"="+reference,
            "select * from "+table+" where "+param+"="+reference+" and "+secondParam+"="+secondRef+""
            };
            Console.WriteLine(sql[mode]);

            OdbcCommand mycommand = new OdbcCommand(sql[mode], this.con.connection());
            OdbcDataReader dt = mycommand.ExecuteReader();
            this.con.myconn.Close();
            return dt;
        }

        public OdbcDataReader getLast(string sql)
        {
            OdbcCommand mycommand = new OdbcCommand(sql, this.con.connection());
            OdbcDataReader dt = mycommand.ExecuteReader();
            this.con.myconn.Close();
            return dt;

        }


        public void executerCommand(string query)
        {
            Console.WriteLine("Creating command");

            this.con.myconn.Open();
            OdbcCommand mycommand = new OdbcCommand(query, con.myconn);
            Console.WriteLine("Before execute");
            mycommand.ExecuteNonQuery();
            this.con.myconn.Close();
        }

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuentaDeb, string numCuentaCred, string estado)
        {
            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_movimientosBancarios ( movban_valor_transaccion, movban_descripcion_transaccion, fk_num_cuentaDebito, fk_num_cuentaCredito, movban_status, movban_fecha_de_ingreso) VALUES (?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@movban_valor_transaccion", valorMovimiento);
                                cmd.Parameters.AddWithValue("@movban_descripcion_transaccion", descripcionMovimiento);
                                cmd.Parameters.AddWithValue("@fk_movban_num_cuenta_debito", numCuentaDeb);
                                cmd.Parameters.AddWithValue("@fk_movban_num_cuenta_credito", numCuentaCred);
                                cmd.Parameters.AddWithValue("@movban_status", estado);
                                cmd.Parameters.AddWithValue("@movban_fecha_de_ingreso", DateTime.Now);


                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar el registro: {ex.Message}");
                        }
                    }
                }
            }
        }

        public DataTable llenarTblMov(string tabla) //Llenar tabla de reportes
        {
            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    string sql = "SELECT pk_movban_id_transaccion, movban_valor_transaccion, movban_descripcion_transaccion, fk_num_cuentaDebito, fk_num_cuentaCredito, movban_status, movban_fecha_de_ingreso FROM  " + tabla + ";";
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);
                    return table;
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable TipoTransaccionBancaria()
        {
            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    string sql = "SELECT movtm_transacciones_existentes  FROM tbl_mantenimientos_tipo_movimiento;";
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);
                    return table;
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable valorTransaccion()
        {
            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    string sql = "SELECT movtm_valor_transaccion FROM tbl_mantenimientos_tipo_movimiento;";
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);
                    return table;
                }
                else
                {
                    return null;
                }
            }
        }

        public int ObtenerValorTransaccion(string tipoTransaccion)
        {
            int valorTransaccion = 0; // Valor predeterminado (por ejemplo, pasivo)

            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    string query = "SELECT movtm_valor_transaccion FROM tbl_mantenimientos_tipo_movimiento WHERE movtm_transacciones_existentes = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", tipoTransaccion);
                        OdbcDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            valorTransaccion = reader.GetInt32(0);
                        }
                    }
                }
            }


            return valorTransaccion;
        }



        public List<Cuenta> getUserAccounts(int Id)
        {
            List<Cuenta> accounts = new List<Cuenta>();
            try
            {
                string query = "select cue_id, cue_cliente, cue_saldo, cue_tipo, cue_moneda, cue_numero, cue_usuario, cli_nombre from tbl_cuenta  inner join tbl_cliente on cli_id = cue_cliente where cue_usuario='" + Id + "'";
                Console.WriteLine(query);
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new Cuenta(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7)));
                }
                return accounts;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }

        public void makeDepositTransaction(int origin, int dest, double monto)
        {
            try
            {
                string query = "call transaccion_deposito('" + origin + "', '" + dest + "', '" + monto + "');";
                Console.WriteLine(query);
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }


        public Cuenta getAccountByNumber(string accountNumber)
        {
            try
            {
                string query = "select cue_id, cue_cliente, cue_saldo, cue_tipo, cue_moneda, cue_numero, cue_usuario, cli_nombre from tbl_cuenta  inner join tbl_cliente on cli_id = cue_cliente where cue_numero='" + accountNumber + "'";
                Console.WriteLine(query);
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Cuenta(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                }
                return null;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }

        public int getUserProfileById(int userId)
        {
            string sql = "select * from tbl_asignacionesperfilsusuario where fk_id_usuario='" + userId + "' ";
            OdbcCommand cmd = new OdbcCommand(sql, this.con.connection());
            OdbcDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(1);
            }
            return -1;
        }


    }
}
