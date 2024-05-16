using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Sentences
{
    public class Check
    {
        public int Id;
        public int IdCheckbook;
        public double amount;
        public int status;

        public Check(int id, int idCheckbook, double amount, int status)
        {
            Id = id;
            IdCheckbook = idCheckbook;
            this.amount = amount;
            this.status = status;
        }
    }
}
