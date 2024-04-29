using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloERP.clases
{
    public class ProductoM
    {
        public string nombre;
        public int codigo;
        public string descripcion;
        public double precio;
        public int marca;
        public int cantidad;
        public int linea;

        public ProductoM(int codigo, string nombre, string descripcion, double precio, int marca, int cantidad, int linea)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.marca = marca;
            this.cantidad = cantidad;
            this.linea = linea;
        }
    }
}
