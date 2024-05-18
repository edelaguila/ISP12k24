using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorERP;
using Xunit;

namespace MovimientoVentasDavid.Tests
{
   
    public class MovimientoCompras
    {
        Controlador cn = new Controlador();
        [Fact]
        public void insertarCliente()
        {
            // Arrange
            string nombre_cl = "Pablo";
            string apellido_cl = "Morales";
            string direccion_cl = "villa nueva";
            string correo_cl = "Pabluski@mail.com";
            string telefono_cl = "24128745";
            // Act
            bool insercionCliente;

            try
            {
                cn.insertarCliente(nombre_cl, apellido_cl, direccion_cl, correo_cl, telefono_cl);
                insercionCliente = true;
            }
            catch
            {
                insercionCliente = false;
            }

            // Assert
            Assert.True(insercionCliente);
        }
        [Fact]
        public void InsertarCoti()
        {
            // Arrange
            int No_Cotizacion = 11;
            string fecha_coti = "2024/05/17";
            string fechaFinal_coti = "2024/05/19";
            string Solicitud = "Cotizacion";
            // Act
            bool insercionCoti;

            try
            {
                cn.InsertarCoti(No_Cotizacion, fecha_coti, fechaFinal_coti, Solicitud);
                insercionCoti = true;
            }
            catch
            {
                insercionCoti = false;
            }

            // Assert
            Assert.True(insercionCoti);
        }

        [Fact]
        public void InsertarDetalleCoti()
        {
            // Arrange
            int id_cliente =32;
            int cantidad_coti = 25 ;
            int No_Cotizacion = 36 ;
            int cod_producto = 1 ;
            double total_detCoti =  223.35;
            // Act
            bool insercionDetalleCoti;

            try
            {
                cn.InsertarDetalleCoti(id_cliente, cantidad_coti, No_Cotizacion, cod_producto, total_detCoti);
                insercionDetalleCoti = true;
            }
            catch
            {
                insercionDetalleCoti = false;
            }

            // Assert
            Assert.True(insercionDetalleCoti);
        }



    }
}
