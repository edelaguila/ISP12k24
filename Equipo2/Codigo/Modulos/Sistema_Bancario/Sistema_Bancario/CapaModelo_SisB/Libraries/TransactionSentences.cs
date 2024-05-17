using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_SisB.Libraries
{
    public class TransactionSentences
    {
        public static Conexion conn = new Conexion();
        public static void updateBalanceFromAccount(int Id, double amount)
        {
            string sql = "update tbl_cuenta set cue_saldo=cue_saldo+('" + amount + "') where cue_id ='" + Id + "' ";
            OdbcCommand cmd = new OdbcCommand(sql, conn.connection());
            cmd.ExecuteNonQuery();
        }
    }
}
