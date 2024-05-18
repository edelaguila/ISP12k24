using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CapaControladorERP;

namespace MovimientoBancosCarlos.Tests
{
    public class MovimientoDeBanco
    {
        Controlador cn = new Controlador();

        [Fact]
        public void TestEliminarMovimiento()
        {
            // Arrange
            int idMovimientoAEliminar = 2; // ID de movimiento que deseas eliminar

            // Act
            bool eliminacionExitosa = cn.EliminarMovimiento(idMovimientoAEliminar);

            // Assert
            Assert.True(eliminacionExitosa); // Verificar que la eliminación fue exitosa
        }

        [Fact]
        public void TestEliminarMovimientoNoExistente()
        {
            // Arrange
            int idMovimientoNoExistente = 900; // ID de un movimiento que sabemos que no existe

            // Act
            bool eliminacionExitosa = cn.EliminarMovimiento(idMovimientoNoExistente);

            // Assert
            Assert.False(eliminacionExitosa); // Verificar que la eliminación no fue exitosa
        }

        [Fact]
        public void TestGuardarDatos()
        {
            // Arrange
            string tabla = "tbl_conceptomovimientodebancos";
            var valores = new Dictionary<string, object>
            {
                { "concepto_movimientoBanco", "Prueba" },
                { "efecto_movimientoBanco", "+" },
                { "estado_movimientoBanco", "Activo" }
            };

            // Act
            bool guardadoExitoso = cn.GuardarDatos(tabla, valores);

            // Assert
            Assert.True(guardadoExitoso); // Verificar que el guardado fue exitoso
        }

    }
}
