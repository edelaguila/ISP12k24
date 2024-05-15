using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using CapaModelo_SisB.Templates;

namespace CapaModelo_SisB
{
     public class AccountSentence : Conexion
    {

        public Conexion con;
        private static string baseDatos = "";

        public AccountSentence()
        {
            this.con = new Conexion();
            this.con.myconn.Open();
            baseDatos = this.con.myconn.Database;
            this.con.myconn.Close();
        }

        public List<string> getAccountsNames()
        {
            List<string> accountsNames = new List<string>();
            OdbcDataReader reader = this._get("", "SELECT cue_id, cli_nombre, cli_nit, cue_saldo FROM tbl_cuenta inner join tbl_cliente on cli_id = cue_cliente");
            while (reader.Read())
            {
                string name = reader.GetString(1);
                accountsNames.Add(name);
            }
            return accountsNames;
        }

        public List<Account> getAccounts()
        {
            List<Account> accounts = new List<Account>();
            OdbcDataReader reader = this._get("", "SELECT cue_id, cli_nombre, cli_nit, cue_saldo FROM tbl_cuenta inner join tbl_cliente on cli_id = cue_cliente");
            while (reader.Read())
            {
                Account acc = new Account(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
                accounts.Add(acc);
            }
            Console.WriteLine(accounts.Count);
            return accounts;
        }


        public OdbcDataReader _get(string _table, string sql = "")
        {
            try
            {
                string query = sql.Equals("") ? "select * from " + _table : sql;
                OdbcCommand cmd = new OdbcCommand(query, this.con.connection());
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }


        public Account getAccountByNit(string nit)
        {
            string sql = "select cue_id, cli_nombre, cue_numero, cue_saldo, cli_nit from tbl_cuenta inner join tbl_cliente on cue_cliente = cli_id where cli_nit = '" + nit + "'";
            OdbcDataReader reader = this._get("", sql);
            if (reader.Read())
            {
                return new Account(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
            }
            return null;
        }



        public Account getAccountBalance(string accountNo)
        {
            string sql = "SELECT cue_id, cli_nombre, cue_numero, cue_saldo FROM tbl_cuenta inner join tbl_cliente on cli_id = cue_cliente";
            OdbcDataReader reader = this._get("", sql);
            if (reader.Read())
            {
                return new Account(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));
            }
            return null;
        }

        public bool checkPaymentViability(string accountNit, double amount)
        {
            string sql = "select  cue_saldo from tbl_cuenta inner join tbl_cliente on cue_cliente = cli_id where cli_nit = '" + accountNit + "'";
            OdbcDataReader reader = this._get("", sql);
            if (reader.Read())
            {
                return (reader.GetDouble(0) - amount) > 0;
            }
            return false;
        }



        public void makeServicePayment(string accountNit, double amount)
        {
            string sql = "update tbl_cuenta inner join tbl_cliente on cli_id = cue_cliente set cue_saldo=cue_saldo-'" + amount + "' where cli_nit='" + accountNit + "'";
            OdbcCommand cmd = new OdbcCommand(sql, this.con.connection());
            cmd.ExecuteNonQuery();
        }
    }
}
