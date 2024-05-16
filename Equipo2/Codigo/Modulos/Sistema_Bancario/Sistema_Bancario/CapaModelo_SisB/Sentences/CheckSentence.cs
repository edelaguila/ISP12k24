using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_SisB.Sentences
{
    public class CheckSentence
    {
        public static Conexion conn = new Conexion();
        public static void createChecksFromCheckbook(int cant, int CheckbookID)
        {
            conn.myconn.Open();
            string sql = "insert into tbl_cheques(ch_chequera, ch_monto, ch_estado)values('" + CheckbookID + "', '" + 0 + "', '" + 0 + "')";
            OdbcCommand cmd = new OdbcCommand(sql, conn.myconn);
            for (int i = 0; i < cant; i++)
            {
                cmd.ExecuteNonQuery();
            }
            conn.myconn.Close();
        }

        public static List<Check> getChecksFromCheckbook(int CheckbookId)
        {
            conn.myconn.Open();
            List<Check> checks = new List<Check>();
            string sql = "select * from tbl_cheques where ch_chequera='" + CheckbookId + "'";
            OdbcCommand cmd = new OdbcCommand(sql, conn.myconn);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                checks.Add(new Check(reader.GetInt32(0), reader.GetInt32(1), reader.GetDouble(2), reader.GetInt32(3)));
            }
            conn.myconn.Close();
            return checks;
        }

        public static void updateCheckById(int Id, double amount)
        {
            conn.myconn.Open();
            string sql = "update tbl_cheques set ch_monto='" + amount + "', ch_estado='" + 1 + "' where ch_id='" + Id + "'";
            OdbcCommand cmd = new OdbcCommand(sql, conn.myconn);
            cmd.ExecuteNonQuery();
            conn.myconn.Close();
        }






    }
}
