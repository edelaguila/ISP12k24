using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_SisB
{
   public class Conexion
    {

        public OdbcConnection myconn;
        public Conexion()
        {
            this.myconn = new OdbcConnection("Dsn=HotelSConexion");
        }


        public OdbcConnection connection()
        {
            try
            {
                this.myconn = new OdbcConnection("Dsn=HotelSConexion");
                myconn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return myconn;
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
