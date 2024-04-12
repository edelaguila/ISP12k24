using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Security.Policy;

namespace CapaModeloERP
{

    public class Producto
    {
        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }

    }


    public class Sentencias
    {
        Conexion con = new Conexion();
        private OdbcDataAdapter adaptador;
        private DataTable tabla;
        public OdbcDataAdapter CargarDatos(string tabla)
        {
            string query = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter data = new OdbcDataAdapter(query, con.connection());
            return data;
        }

        



        public void InsertarCliente(string nombre_cl, string apellido_cl, string direccion_cl, string correo_cl, string telefono_cl)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_clientes (nombre_cl, apellido_cl, direccion_cl, correo_cl, telefono_cl) VALUES (?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@nombre_cl", nombre_cl);
                                cmd.Parameters.AddWithValue("@apellido_cl", apellido_cl);
                                cmd.Parameters.AddWithValue("@direccion_cl", direccion_cl);
                                cmd.Parameters.AddWithValue("@correo_cl", correo_cl);
                                cmd.Parameters.AddWithValue("@telefono_cl", telefono_cl);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al guardar el cliente: {ex.Message}");
                        }
                    }
                }
            }
        }

        public void InsertarCoti(int No_Cotizacion, string fecha_coti, string fechaFinal_coti)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_cotizaciones (No_Cotizacion, fecha_coti, fechaFinal_coti) VALUES (?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@No_Cotizacion", No_Cotizacion);
                                cmd.Parameters.AddWithValue("@fecha_coti", fecha_coti);
                                cmd.Parameters.AddWithValue("@fechaFinal_coti", fechaFinal_coti);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al guardar la cotización: {ex.Message}");
                        }
                    }
                }
            }
        }


        public List<string> ComboFill(string columna, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.connection());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna].ToString();
                    datos.Add(ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;
        }

        public double GetPrecio(string nombreProducto)
        {
            double precioUnitario = 0.0;
            OdbcConnection connection = null;

            try
            {
                connection = con.connection();
                if (connection != null)
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string selectQuery = "SELECT precioUnitario_prod FROM tbl_producto WHERE nombre_prod = ?";

                    using (OdbcCommand command = new OdbcCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nombreProducto", nombreProducto);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            precioUnitario = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el precio unitario del producto: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return precioUnitario;
        }

        public string ObtenerCliente(string nombrecliente)
        {
            try
            {
                using (OdbcConnection connection = con.connection())
                {
                    using (OdbcCommand cmd = new OdbcCommand("SELECT id_cliente FROM tbl_clientes WHERE nombre_cl= ?", connection))
                    {
                        cmd.Parameters.Add(new OdbcParameter("nombre_cliente", nombrecliente));
                        string descripcion = cmd.ExecuteScalar().ToString();
                        return descripcion;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null; 
            }
        }
        public string ObtenerUltimoIdCoti()
        {
            try
            {
                using (OdbcConnection connection = con.connection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (OdbcCommand cmd = new OdbcCommand("SELECT No_Cotizacion FROM tbl_cotizaciones ORDER BY No_Cotizacion DESC LIMIT 1", connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string ultimoIdCoti = result.ToString();
                            return ultimoIdCoti;
                        }
                        else
                        {
                            return "No hay cotizaciones registradas.";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }


        public void InsertarDetalleCoti(int id_cliente, int cantidad_coti, int No_Cotizacion, int cod_producto, double total_detCoti)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_detalle_cotizacion (tbl_clientes_id_cliente, cantidad_coti, tbl_cotizaciones_No_Cotizacion, tbl_producto_cod_producto, total_detCoti) VALUES (?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                                cmd.Parameters.AddWithValue("@cantidad_coti", cantidad_coti);
                                cmd.Parameters.AddWithValue("@No_Cotizacion", No_Cotizacion);
                                cmd.Parameters.AddWithValue("@cod_producto", cod_producto);
                                cmd.Parameters.AddWithValue("@total_detCoti", total_detCoti);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al guardar el detalle de la cotización: {ex.Message}");
                        }
                    }
                }
            }
        }

        public int ObtenerCodigoProducto(string nombreProducto)
        {
            int codigoProducto = 0;

            try
            {
                using (OdbcConnection connection = con.connection())
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string query = "SELECT cod_producto FROM tbl_producto WHERE nombre_prod = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, connection))
                    {
                        cmd.Parameters.Add(new OdbcParameter("nombre_producto", nombreProducto));
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            codigoProducto = Convert.ToInt32(result);
                        }
                    } 
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el código del producto: " + ex.Message);
            }

            return codigoProducto;
        }

        // carlos enrique modulo bancos
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

        // carlos enrique modulo bancos
        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.connection());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        // carlos enrique modulo bancos
        public bool Guardar(string tabla, Dictionary<string, object> valores)
        {


            using (OdbcConnection conn = con.connection())
            {
                string columnas = string.Join(", ", valores.Keys);
                string parametros = string.Join(", ", valores.Keys.Select(key => "?"));
                string consulta = $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})";

                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    foreach (var kvp in valores)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }


        }
        // carlos enrique modulo bancos
        public bool ActualizarSaldoCuentaBancaria(int idCuenta, double monto, bool esDeposito)
        {
            string operador = esDeposito ? "+" : "-";
            string consulta = $"UPDATE tbl_cuentaBancaria SET saldoDisponible = saldoDisponible {operador} ? WHERE id_cuentaBancaria = ?";

            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@id_cuenta", idCuenta);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }


    }

}
