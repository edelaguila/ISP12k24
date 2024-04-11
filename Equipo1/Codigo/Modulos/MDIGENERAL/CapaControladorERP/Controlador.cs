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

    }
}
