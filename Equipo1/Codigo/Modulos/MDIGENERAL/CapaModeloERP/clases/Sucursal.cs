using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloERP.clases
{
    public class Sucursal
    {
        public string codigo;
        public string nombre;
        public string dir;
        public string telefono;
        public string correo;

        public Sucursal(string codigo, string nombre, string dir, string telefono, string correo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.dir = dir;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
