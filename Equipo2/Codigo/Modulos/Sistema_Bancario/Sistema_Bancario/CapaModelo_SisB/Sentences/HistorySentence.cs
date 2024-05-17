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

  public class HistorySentence{

    public static Conexion conn = new Conexion();

    public static void saveTransactionOnHistory(int accountId, string type, double amount){
      string sql = "insert into tbl_historial_transacciones(htr_cuenta, htr_tipo, htr_monto, htr_fecha)values(";
      sql += "'"+accountId+"', '"+type+"', '"+amount+"', CURDATE())";
      OdbcCommand cmd = new OdbcCommand(sql, conn.connection());
      cmd.ExecuteNonQuery();
    }

  }
}
