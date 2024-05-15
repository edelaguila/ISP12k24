using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using CapaModelo_SisB.Templates;

namespace CapaModelo_SisB
{
    public class Provider
    {

        private Conexion conn;

        public Provider()
        {
            this.conn = new Conexion();
        }

        public List<Moneda> getMonedas()
        {
            List<Moneda> monedas = new List<Moneda>();
            OdbcDataReader reader = this._get("tbl_moneda");
            this.catchErr(reader);
            while (reader.Read())
            {
                Moneda moneda = new Moneda(reader.GetInt32(0), reader.GetString(1));
                monedas.Add(moneda);
            }
            return monedas;
        }


        public List<TipoCuenta> getTiposCuentas()
        {
            List<TipoCuenta> tcuentas = new List<TipoCuenta>();
            OdbcDataReader reader = this._get("tbl_tipo_cuenta");
            this.catchErr(reader);
            while (reader.Read())
            {
                tcuentas.Add(new TipoCuenta(reader.GetInt32(0), reader.GetString(1)));
            }
            return tcuentas;
        }

        public List<Cliente> getClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            OdbcDataReader reader = this._get("tbl_cliente");
            this.catchErr(reader);
            while (reader.Read())
            {
                clientes.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5)));
            }
            return clientes;
        }


        public void catchErr(OdbcDataReader reader)
        {
            if (reader == null)
            {
                Console.WriteLine("is null");
                return;
            }
        }
        public OdbcDataReader _get(string _table)
        {
            try
            {
                string query = "select * from " + _table;
                OdbcCommand cmd = new OdbcCommand(query, this.conn.connection());
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null;
        }

        public List<string> getSingleRowValues(string table)
        {
            OdbcDataReader reader = this._get(table);
            List<string> rows = new List<string>();
            while (reader.Read())
            {
                rows.Add(reader.GetString(1));
            }
            return rows;
        }

    }
}
