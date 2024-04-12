using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Templates
{
    public class Moneda
    {
        public int id;
        public string name;
        public Moneda(int id, string n)
        {
            this.id = id;
            this.name = n;
        }

        public Moneda()
        {
            this.id = 0;
            this.name = "";
        }
    }
}
