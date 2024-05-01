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
        public int idTipo;
        public int idMoneda;
        public string numero;
        public int idUsuario;

        public Cuenta(int id, int idCliente, double saldo, int idTipo, int idMoneda, string numero, int idUsuario)
        {
            this.id = id;
            this.idCliente = idCliente;
            this.saldo = saldo;
            this.idTipo = idTipo;
            this.idMoneda = idMoneda;
            this.numero = numero;
            this.idUsuario = idUsuario;
        }
    }
}
