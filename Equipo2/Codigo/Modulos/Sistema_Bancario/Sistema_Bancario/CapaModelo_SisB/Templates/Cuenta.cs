using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Templates
{
    public class Cuenta
    {
        public int id;
        public int idCliente;
        public double saldo;
        public string nombre;
        public int idTipo;
        public int idMoneda;
        public string numero;
        public int idUsuario;
        public List<Cuenta> friend_accounts = new List<Cuenta>();


        public Cuenta(int id, int idCliente, double saldo, int idTipo, int idMoneda, string numero, int idUsuario, string nombre)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.saldo = saldo;
            this.idTipo = idTipo;
            this.idMoneda = idMoneda;
            this.numero = numero;
            this.idUsuario = idUsuario;
            this.nombre = nombre;
        }

        public Cuenta(int id, string name, string no_account, double balance)
        {
            this.saldo = balance;
            this.id = id;
            this.nombre = name;
            this.numero = no_account;
        }

        public void updateTemplateAttributes(int idCliente, double saldo, int idTipo, int idMoneda, string numero, int idUsuario, string nombre)
        {
            this.idCliente = idCliente;
            this.saldo = saldo;
            this.idTipo = idTipo;
            this.idMoneda = idMoneda;
            this.numero = numero;
            this.idUsuario = idUsuario;
            this.nombre = nombre;
        }
        public void updateBalance(double saldo)
        {
            this.saldo = saldo;
        }
    }
}
