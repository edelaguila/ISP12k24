using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Reporteador2._0
{
    public class Sentence
    {
        public Conexion conn;
        public Sentence()
        {
            this.conn = new Conexion();
        }

        public DataTable getTable(string table)
        {
            DataTable dat = new DataTable();
            string sql = "select * from " + table;
            OdbcCommand cmd = new OdbcCommand(sql, this.conn.connection());
            OdbcDataAdapter dt = new OdbcDataAdapter(cmd);
            dt.Fill(dat);
            return dat;
        }
    }
}
