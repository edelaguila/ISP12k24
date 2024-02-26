using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo_MG2.Sentences
{
    public class Boleta
    {
        public int id;
        public int corr;
        public int id_banco;
        public Boleta(int id, int corr, int id_ban)
        {
            this.id = id;
            this.corr = corr;
            this.id_banco = id_ban;
        }
    }
    public class BoletaSentence : Sentencias
    {
        public bool boletaExist(int noBoleta, int corrBoleta, int idBanco)
        {
            return false;
        }

        public bool findBol(int idBol, int idCorr)
        {
            OdbcDataReader dataReader = this.getByParam("bol_id", "bol_correlativo", "tbl_boleta", 2, idBol, idCorr);
            return dataReader.Read();
        }

        public void saveBoleta()
        {
            Boleta bol = new Boleta(0, Math.Abs(Guid.NewGuid().GetHashCode()), 1);

            string sql = "insert into tbl_boleta(bol_correlativo, bol_id_banco)values('" + bol.corr + "', '" + bol.id_banco + "')";
            this.executerCommand(sql);
        }

        public List<string> consulBoleta()
        {
            List<string> datos = new List<string>();
            string consultaSQL = "SELECT * FROM tbl_boleta ORDER BY bol_id DESC";
            OdbcDataReader reader = this.getLast(consultaSQL);
            if (reader.Read())
            {
                string id = reader.GetString(0);
                string correlativo = reader.GetString(1);
                datos.Add(id);
                datos.Add(correlativo);

            }

            return datos;
        }
    }
}
