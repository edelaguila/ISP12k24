using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Templates
{
    public class TipoCuenta
    {
        public int id;
        public string name;
        public TipoCuenta(int id, string n)
        {
            this.name = n;
            this.id = id;
        }


        public TipoCuenta()
        {
            this.name = "";
            this.id = 0;
        }
    }
}
