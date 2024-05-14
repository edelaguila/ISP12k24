using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB.Templates;
using System.Data.Odbc;

namespace CapaModelo_SisB.Libraries
{
    public class AccountTransactions : Cuenta
    {
        public Conexion conn;


        public AccountTransactions(int id, int idCliente, double saldo, int idTipo, int idMoneda, string numero, int idUsuario, string name) : base(id, idCliente, saldo, idTipo, idMoneda, numero, idUsuario, name)
        {
            this.conn = new Conexion();
            this.getFriendAccounts();
        }

        public AccountTransactions(int id, string name, string no_account, double balance) : base(id, name, no_account, balance)
        {
            this.saldo = balance;
            this.id = id;
            this.nombre = name;
            this.numero = no_account;
            this.conn = new Conexion();
            this.getFriendAccounts();
        }


        public void updateBalance(double amount, int sign = 1)
        {
            amount *= sign;
            TransactionSentences.updateBalanceFromAccount(this.id, amount);
        }

        public void updateAttributesFromDatabase()
        {
            string query = "select cue_saldo from tbl_cuenta where cue_id = '" + this.id + "'";
            OdbcCommand cmd = new OdbcCommand(query, this.conn.connection());
            cmd.ExecuteNonQuery();
        }

        public void NonFriendTransaction(int idAccount, double amount, int sign = 1)
        {
            if (sign < 0)
            {
                TransactionSentences.updateBalanceFromAccount(idAccount, amount * sign);
                this.updateBalance(amount, -1);
                this.saldo = this.saldo + (amount * sign);
                return;
            }
            this.updateBalance(amount);
            TransactionSentences.updateBalanceFromAccount(idAccount, amount * -1);
            this.saldo = this.saldo + amount;
        }


        public void makeTransactionWithFriendAccount(int index, double amount)
        {
            Cuenta account = this.friend_accounts[index];
            AccountTransactions friendT = new AccountTransactions(account.id, account.nombre, account.numero, account.saldo);
            this.updateBalance(amount, -1);
            this.saldo = this.saldo - amount;
            friendT.updateBalance(amount);
            account.saldo = account.saldo + amount;
        }

        public void makeWithdrawal(double amount)
        {
            this.updateBalance(amount, -1);
            this.saldo = this.saldo - amount;
        }


        public void getFriendAccounts()
        {
            List<Cuenta> friendAccounts = new List<Cuenta>();
            string sql = "select cue_id, cli_nombre, cue_numero, cue_saldo from tbl_cuenta ";
            sql += "inner join tbl_cuentaamiga on id_cuenta_amiga = cue_id " +
                "inner join tbl_cliente on cli_id = cue_cliente where id_cuenta_principal = '" + this.id + "'";
            OdbcCommand cmd = new OdbcCommand(sql, this.conn.connection());
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                friendAccounts.Add(new Cuenta(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3)));
            }
            this.friend_accounts = friendAccounts;
        }

        public void addFriendAccount(string no_account)
        {
            string sql = "INSERT INTO tbl_cuentaamiga (id_cuenta_principal, id_cuenta_amiga) SELECT '" + this.id + "', cue_id FROM tbl_cuenta WHERE cue_numero = '" + no_account + "';";
            OdbcCommand cmd = new OdbcCommand(sql, this.conn.connection());
            cmd.ExecuteNonQuery();
            this.getFriendAccounts();
        }
    }
}
