using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModeloERP
{
    public class SentenciasTraslado
    {
        public static Conexion conn = new Conexion();
        public static void crearTraslado(string fecha, string solicitante, string entregante, int origen, int destino)
        {
            string sql = "insert into tbl_trasladoprod(fecha_traslado, soliciante_traslado, entregante_traslado, tbl_sucursales_id_sucursal_origen, tbl_sucursales_id_sucursal_destino)values ";
            sql += "('" + fecha + "', '" + solicitante + "', '" + entregante + "', '" + origen + "', '" + destino + "')";
            OdbcCommand cmd = new OdbcCommand(sql, conn.connection());
            cmd.ExecuteNonQuery();
        }

        public static void actualizarExistencias(int idSucursal, int idProducto, int cantidad)
        {
            string sql = "UPDATE tbl_existencias SET ";
            sql += "cantidad = " + cantidad + " ";
            sql += "WHERE tbl_producto_id_producto = " + idProducto + " and tbl_sucursales_id_sucursal='" + idSucursal + "'";
            OdbcCommand cmd = new OdbcCommand(sql, conn.connection());
            cmd.ExecuteNonQuery();
        }


        public static bool VerificarExistenciaProducto(int idSucursal, int idProducto, int cantidadRequerida = 1)
        {
            bool existeExistenciaSuficiente = false;
            string sql = "SELECT cantidad FROM tbl_existencias WHERE tbl_sucursales_id_sucursal = ? AND tbl_producto_id_producto = ?";

            OdbcCommand command = new OdbcCommand(sql, conn.connection());
            command.Parameters.AddWithValue("id_sucursal", idSucursal);
            command.Parameters.AddWithValue("id_producto", idProducto);

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                int cantidadDisponible = Convert.ToInt32(result);
                if (cantidadDisponible >= cantidadRequerida)
                {
                    existeExistenciaSuficiente = true;
                }
            }
            return existeExistenciaSuficiente;
        }


        public static void crearExistencia(int idSucursal, int idProducto, int cantidad)
        {
            string sql = "INSERT INTO tbl_existencias (tbl_sucursales_id_sucursal, tbl_producto_id_producto, cantidad) ";
            sql += "VALUES ('" + idSucursal + "', '" + idProducto + "', " + cantidad + ")";
            OdbcCommand cmd = new OdbcCommand(sql, conn.connection());
            cmd.ExecuteNonQuery();
        }

        public static int existenciasDeProducto(int idSucursal, int idProducto)
        {
            string sql = "select cantidad from tbl_existencias where tbl_sucursales_id_sucursal='" + idSucursal + "' and tbl_producto_id_producto='" + idProducto + "'";
            OdbcCommand cmd = new OdbcCommand(sql, conn.connection());
            OdbcDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.IsDBNull(0)) return -1;
                return reader.GetInt32(0);
            }
            return -1;
        }
        public static OdbcDataAdapter ObtenerExistencias()
        {
            string sql = "SELECT nombre_sucursal, nombre_prod, cantidad FROM tbl_existencias inner join tbl_sucursales on tbl_sucursales_id_sucursal = id_sucursal inner join tbl_producto on tbl_producto.cod_producto = tbl_existencias.tbl_producto_id_producto";
            OdbcDataAdapter data = new OdbcDataAdapter(sql, conn.connection());
            return data;
        }

    }
}
