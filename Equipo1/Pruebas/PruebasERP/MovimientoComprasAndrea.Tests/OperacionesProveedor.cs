using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorERP;
using Xunit;

namespace MovimientoComprasAndrea.Tests
{
    public class OperacionesProveedor
    {
        Controlador cn = new Controlador();
        [Fact]
        public void InsertarOperacionProve()
        {
            // Arrange
            int id = 1;
            string fechaabono = "2024-05-17";
            double total = 1200.00;
           
            // Act
            bool insercionExitosa;

            try
            {
                cn.InsertarOperacion(id, fechaabono, total);
                insercionExitosa = true;
            }
            catch
            {
                insercionExitosa = false;
            }

            // Assert
            Assert.True(insercionExitosa);
        }
        [Fact]
        public void InsertarDetalleOperacionProve()
        {
            // Arrange
            int noFactu = 3;
            string banco = "Banrural";
            string tipo = "Pago";
            string numerodoc = "112543";
            string concepto = "Pago de facturas";

            // Act
            bool insercionExitosa;

            try
            {
                cn.InsertarDetalleOperacionPro(noFactu, banco, tipo, numerodoc, concepto);
                insercionExitosa = true;
            }
            catch
            {
                insercionExitosa = false;
            }

            // Assert
            Assert.True(insercionExitosa);
        }
    }
}
