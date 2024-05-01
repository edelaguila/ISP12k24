using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Templates
{
    public class CuentaAmiga
    {
        public int id;
        public string cliente;
        public string numero;

        public CuentaAmiga(int id, string cliente, string numero)
        {
            this.id = id;
            this.cliente = cliente;
            this.numero = numero;
        }
    }
}
