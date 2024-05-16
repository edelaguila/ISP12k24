using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB.Templates;
using CapaModelo_SisB;
using System.Data.Odbc;

namespace CapaModelo_SisB.Sentences
{
    public class CheckbookSentence
    {
        public static Conexion conn = new Conexion();
        public CheckbookSentence()
        {
            conn = new Conexion();
        }
        static Random random = new Random();

        static string getNewCheckbookCode()
        {
            int numeroAleatorio = random.Next(1000, 10000);
            char letraAleatoria = (char)random.Next('A', 'Z' + 1);
            return $"BF{letraAleatoria}{numeroAleatorio}";
        }

        public static void addCheckbookToAccount(int idAccount)
        {
            conn.myconn.Open();
            string checkbookCode = getNewCheckbookCode();
            string sql = "insert into tbl_chequera(chqra_cuenta)values('" + idAccount + "')";
            OdbcCommand cmd = new OdbcCommand(sql, conn.myconn);
            cmd.ExecuteNonQuery();
            conn.myconn.Close();
        }

        public static Chequera getCheckbookAccount(int accountId)
        {
            try
            {

                conn.myconn.Open();
                string sql = "select * from tbl_chequera where chqra_cuenta='" + accountId + "'";
                Console.WriteLine(sql);
                OdbcCommand cmd = new OdbcCommand(sql, conn.myconn);
                OdbcDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Chequera ch = new Chequera(reader.GetInt32(0), reader.GetInt32(1));
                    conn.myconn.Close();
                    return ch;

                }
                conn.myconn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

    }
}















