using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloERP;
namespace CapaControladorERP
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public DataTable llenarTablas(string tabla)
        {
            OdbcDataAdapter dt = sn.CargarDatos(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public List<string> ComboFill(string columna, string tabla)
        {
            return sn.ComboFill(columna, tabla);
        }
        public double GetPrecio(string nombreProducto)
        {
            double precio = sn.GetPrecio(nombreProducto);
            return precio;
        }

        public void insertarCliente(string nombre_cl, string apellido_cl, string direccion_cl, string correo_cl, string telefono_cl)
        {
            sn.InsertarCliente(nombre_cl, apellido_cl, direccion_cl, correo_cl, telefono_cl);
        }

        public Vendedor BuscarVendedorPorID(int id)
        {
            Vendedor vendedor = sn.BuscarVendedorPorID(id);
            return vendedor;
        }
    }
}
