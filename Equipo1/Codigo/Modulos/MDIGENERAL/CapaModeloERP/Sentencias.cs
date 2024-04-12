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
    //David Carrillo 0901-20-3201 
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

        //Andrea Corado 0901-20-2841
        public OdbcDataAdapter CargarDatos(string tabla)
        {
           string query = "SELECT * FROM " + tabla + ";";
           OdbcDataAdapter data = new OdbcDataAdapter(query, con.connection());
           return data;
        }
        //Andrea Corado 0901-20-2841

        public OdbcDataAdapter BuscarProv(string tabla, string columna, string dato, string columna2, string dato2, string columna3, string dato3)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}' OR {columna2} = '{dato2}' OR {columna3} = '{dato3}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.connection());
            return datos;
        }

        //David Carrillo 0901-20-3201 
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
        //David Carrillo 0901-20-3201 
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

        //David Carrillo 0901-20-3201 
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

        //David Carrillo 0901-20-3201 
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
        //David Carrillo 0901-20-3201 
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
        //David Carrillo 0901-20-3201 
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

        //David Carrillo 0901-20-3201 
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
        //David Carrillo 0901-20-3201 
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
        // Otto Adrian Lopez Ventura
        public DataTable BuscarVendedor(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.connection());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
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

        //Carol Chuy Modulo de Compras
        public string[] llenarCmbprod()
        {
            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT cod_producto, nombre_prod FROM tbl_producto;";

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
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo"); }
            return Campos;
        }

        //Carol Chuy Modulo de Compras
        public DataTable obtenerprod()
        {

            string sql = "SELECT cod_producto, nombre_prod FROM tbl_producto;";

            OdbcCommand command = new OdbcCommand(sql, con.connection());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        //Carol Chuy Modulo de Compras
        public int ObtenerUltimoNumeroOrden(string campoid, string tabla)
        {
            int ultimoNumeroOrden = 0;
            Conexion con = new Conexion();
            OdbcConnection conn = con.connection();

            // Conectar a la base de datos utilizando la clase Conexion
            using (conn)
            {
                // Consulta SQL para obtener el último número de orden
                string query = "SELECT MAX(" + campoid + ") FROM " + tabla + ";";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        ultimoNumeroOrden = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        ultimoNumeroOrden++;
                    }
                }
            }

            // 'conn' se cerrará automáticamente
            return ultimoNumeroOrden;
        }

        //Carol Chuy Modulo de Compras
        //Buscar todo de cualquier tabla
        public OdbcDataAdapter llenarTablas(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.connection());
            return dataTable;
        }

        //Carol Chuy Modulo de Compras
        public string ObtenerDescripcion(string productId)
        {
            string descripcion = string.Empty;
            using (OdbcConnection conn = con.connection())
            {
                string query = "SELECT descripcion_prod FROM tbl_producto WHERE cod_producto = " + productId + ";";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", productId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        descripcion = result.ToString();
                    }
                }
            }
            return descripcion;
        }

        //Carol Chuy Modulo de Compras
        public decimal ObtenerPrecioUnitario(string productId)
        {
            decimal precioUnitario = 0;
            using (OdbcConnection conn = con.connection())
            {
                string query = "SELECT precioUnitario_prod FROM tbl_producto WHERE cod_producto = " + productId + ";";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", productId);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        precioUnitario = Convert.ToDecimal(result);
                    }
                }
            }
            return precioUnitario;
        }

        //Carol Chuy Modulo de Compras
        public string ObtenerNombreProveedor(string proveedorID)
        {
            string query = "SELECT nombre_prov FROM tbl_proveedor WHERE id_prov = " + proveedorID + ";";

            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty; // Se irá aquí en caso de no encontrar al proveedor
        }

        //Carol Chuy Modulo de Compras
        public string ObtenerDomicilioProveedor(string proveedorID)
        {
            string query = "SELECT domicilio_prov FROM tbl_proveedor WHERE id_prov = " + proveedorID + ";";

            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty;
        }

        //Carol Chuy Modulo de Compras
        public string ObtenerTelefonoProveedor(string proveedorID)
        {
            string query = "SELECT telefono_prov FROM tbl_proveedor WHERE id_prov = " + proveedorID + ";";

            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty;
        }

        //Carol Chuy Modulo de Compras
        public string ObtenerNitProveedor(string proveedorID)
        {
            string query = "SELECT nit_prov FROM tbl_proveedor WHERE id_prov = " + proveedorID + ";";

            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                }
            }

            return string.Empty;
        }

        //Carol Chuy Modulo de Compras
        public OdbcDataAdapter llenarTablasCondicion(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + " WHERE recibidoIgualSolicitado_EncComp=1;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.connection());
            return dataTable;
        }


    }

}
