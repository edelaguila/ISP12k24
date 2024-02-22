using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace CapaModelo_MG2
{

    public class Sentencias
    {

        protected Conexion con;
        private static string baseDatos = "";
        public Sentencias()
        {
            this.con = new Conexion();
            baseDatos = this.con.connection().Database;
        }
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.connection());
            return dataTable;
        }



        public OdbcDataReader getByParam<T>(string param, string secondParam, string table, int mode = 0, T reference = default, T secondRef = default)
        {
            string[] sql = {
        "select * from "+table,
        "select * from "+table+" where "+param+"="+reference,
        "select * from "+table+" where "+param+"="+reference+" and "+secondParam+"="+secondRef+""
    };
            Console.WriteLine(sql[mode]);

            using (OdbcCommand mycommand = new OdbcCommand(sql[mode], this.con.connection()))
            {
                return mycommand.ExecuteReader();
            }
        }




        public void executerCommand(string query)
        {
            Console.WriteLine("Creating command");
            OdbcCommand mycommand = new OdbcCommand(query, con.connection());
            Console.WriteLine("Before execute");
            mycommand.ExecuteNonQuery();
        }

    }

}
