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
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {

            this.con.myconn.Open();
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.myconn);
            //this.con.myconn.Open();
            return dataTable;
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

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuentaDeb, string numCuentaCred, string tipoTransaccion, string estado, string valorTrans, string estadoConciliacion)
        {
            using (OdbcConnection connection = this.con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_movimientosBancarios (pk_movban_id_transaccion, movban_valor_transaccion, movban_descripcion_transaccion, movban_movban_num_cuenta_debito, movban_movban_num_cuenta_credito, fk_movban_tipo_transaccion, fk_movban_valorTrans, movban_status, movban_fecha_de_ingreso) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@movban_valor_transaccion", valorMovimiento);
                                cmd.Parameters.AddWithValue("@movban_descripcion_transaccion", descripcionMovimiento);
                                cmd.Parameters.AddWithValue("@fk_movban_num_cuenta_debito", numCuentaDeb);
                                cmd.Parameters.AddWithValue("@fk_movban_num_cuenta_credito", numCuentaCred);
                                cmd.Parameters.AddWithValue("@fk_movban_tipo_transaccion", tipoTransaccion);
                                cmd.Parameters.AddWithValue("@fk_movban_valorTrans", valorTrans);
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
                    string sql = "SELECT pk_movban_id_transaccion, movban_valor_transaccion, movban_descripcion_transaccion, movban_movban_num_cuenta_debito, movban_movban_num_cuenta_credito, fk_movban_tipo_transaccion, fk_movban_valorTrans, movban_status, movban_fecha_de_ingreso FROM  " + tabla + ";";
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


        public List<CuentaAmiga> getFriendAccount(int idReference)
        {
            List<CuentaAmiga> accounts = new List<CuentaAmiga>();
            try
            {
                string query = "call ObtenerCuentasAmigas('" + idReference + "')";
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                OdbcDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CuentaAmiga account = new CuentaAmiga(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    accounts.Add(account);
                }
                return accounts;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }

        public void addFriendAccount(int idReference, string accountFriend)
        {
            try
            {
                string query = "call AgregarCuentaAmiga('" + accountFriend + "', '" + idReference + "')";
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public Cuenta getCurrentAccount(int Id)
        {
            try
            {
                string query = "SELECT * FROM tbl_cuenta where cue_usuario = '" + Id + "';";
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                OdbcDataReader reader = cmd.ExecuteReader();
                return new Cuenta(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6));
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




    }
}
