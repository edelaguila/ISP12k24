using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_SisB.Templates
{
    public class Cliente
    {
        public int id;
        public string nombre;
        public string direccion;
        public string telefono;
        public string dpi;
        public int edad;

        public Cliente(int id, string nombre, string direccion, string telefono, string dpi, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.dpi = dpi;
            this.edad = edad;
        }

        public Cliente()
        {
        }
    }
}
