using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloERP;

namespace CapaControladorERP
{
    public class TrasladoControlador
    {

        public static void createTraslado(string fecha, string solicitante, string entregante, int origen, int destino)
        {
            SentenciasTraslado.crearTraslado(fecha, solicitante, entregante, origen, destino);
        }

        public static void actualizarExistencias(int idSucursal, int idProducto, int cantidad)
        {
            Console.WriteLine("Actualizando: " + idSucursal + "--" + "Prod: " + idProducto + " -- " + cantidad);
            SentenciasTraslado.actualizarExistencias(idSucursal, idProducto, cantidad);
        }

        public static bool productoExiste(int idSucursal, int idProducto, int cantidadRequerida = 1)
        {
            return SentenciasTraslado.VerificarExistenciaProducto(idSucursal, idProducto);
        }

        public static int obtenerCantidadExistencias(int idSucursal, int idProducto)
        {
            return SentenciasTraslado.existenciasDeProducto(idSucursal, idProducto);
        }

        public static void crearExistencia(int idSucursal, int idProducto, int cantidad)
        {
            SentenciasTraslado.crearExistencia(idSucursal, idProducto, cantidad);
        }
        public static DataTable llenarExistencias()
        {
            OdbcDataAdapter dt = SentenciasTraslado.ObtenerExistencias();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

    }
}