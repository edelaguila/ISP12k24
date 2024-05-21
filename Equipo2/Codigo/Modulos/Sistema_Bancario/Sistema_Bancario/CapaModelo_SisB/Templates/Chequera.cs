using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Templates
{
    public class Chequera
    {

        public int Id;
        public int Idcuenta;

        public Chequera(int id, int idcuenta)
        {
            Id = id;
            Idcuenta = idcuenta;
        }
    }
}
