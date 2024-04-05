using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_SisB
{
    class Conexion
    {

        public OdbcConnection myconn;
        public Conexion()
        {
            this.myconn = new OdbcConnection("Dsn=HotelSConexion");
        }


        public OdbcConnection connection()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=HotelSConexion");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }


        public void disconnect(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }

    }
}
