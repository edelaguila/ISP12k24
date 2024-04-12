using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

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
                            string insertQuery = "INSERT INTO tbl_cliente (nombre_cl, apellido_cl, direccion_cl, correo_cl, telefono_cl) VALUES (?, ?, ?, ?, ?)";
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


    }

}
