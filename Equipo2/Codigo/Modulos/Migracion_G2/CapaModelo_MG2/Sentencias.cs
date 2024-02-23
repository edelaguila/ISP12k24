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

        public Conexion con;
        private static string baseDatos = "";
        public Sentencias()
        {
            this.con = new Conexion();
            this.con.myconn.Open();
            baseDatos = this.con.myconn.Database;
            this.con.myconn.Close();
        }
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {

            this.con.myconn.Open();
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.myconn);
            //this.con.myconn.Open();
            return dataTable;
        }



        public OdbcDataReader getByParam<T>(string param, string secondParam, string table, int mode = 0, T reference = default, T secondRef = default)
        {
            this.con.myconn.Open();
            string[] sql = {
            "select * from "+table,
            "select * from "+table+" where "+param+"="+reference,
            "select * from "+table+" where "+param+"="+reference+" and "+secondParam+"="+secondRef+""
            };
            Console.WriteLine(sql[mode]);

            OdbcCommand mycommand = new OdbcCommand(sql[mode], this.con.connection());
            OdbcDataReader dt = mycommand.ExecuteReader();
            this.con.myconn.Close();
            return dt;
        }




        public void executerCommand(string query)
        {
            Console.WriteLine("Creating command");

            this.con.myconn.Open();
            OdbcCommand mycommand = new OdbcCommand(query, con.myconn);
            Console.WriteLine("Before execute");
            mycommand.ExecuteNonQuery();
            this.con.myconn.Close();
        }

    }

}
