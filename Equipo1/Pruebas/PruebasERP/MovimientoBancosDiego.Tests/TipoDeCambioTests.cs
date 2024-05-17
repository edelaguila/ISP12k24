using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CapaControladorERP;

namespace MovimientoBancosDiego.Tests
{
   public  class TipoDeCambioTests
    {
        Controlador cn = new Controlador();

        [Fact]
        public void TestEliminarMovimiento()
        {
            // Arrange
            int idTipoCambioEliminar = 6; // ID de movimiento que deseas eliminar

            // Act
            bool eliminacionExitosa = cn.EliminarTipodecambio(idTipoCambioEliminar);

            // Assert
            Assert.True(eliminacionExitosa); // Verificar que la eliminación fue exitosa
        }

        [Fact]
        public void TestEliminarMovimientoNoExistente()
        {
            // Arrange
            int idMovimientoNoExistente = 1000; // ID de un movimiento que sabemos que no existe

            // Act
            bool eliminacionExitosa = cn.EliminarTipodecambio(idMovimientoNoExistente);

            // Assert
            Assert.False(eliminacionExitosa); // Verificar que la eliminación no fue exitosa
        }

        [Fact]
        public void TestGuardarDatos()
        {
            // Arrange
            


            // Capturar los valores de los controles de la interfaz de usuario
            string monedaOrigen = "Quetzales";
            string monedaDestino = "Dólar";
            double valorCalculado = double.Parse("0.13");
            double totalCalculado = double.Parse("0.13");
            double cantidad = double.Parse("1");
            DateTime fecha = new DateTime(2024, 4, 16);



            // Act
            bool insercionExitosa;

            try
            {
                cn.InsertarTipoCambio(fecha, monedaOrigen, monedaDestino, cantidad, valorCalculado, totalCalculado);
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
