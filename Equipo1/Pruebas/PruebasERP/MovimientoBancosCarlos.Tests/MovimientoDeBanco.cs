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
        public void TestGuardarDatos()
        {
            // Arrange
            string tabla = "tbl_movimientodebancos";
            var valores = new Dictionary<string, object>
            {
                { "tipo_movimientoBanco", "1" },
                { "fecha_movimientoBanco", "2024-05-19" },
                { "monto_movimientoBanco", "5000" },
                { "cuenta_movimientoBanco", "1" },
                { "efecto_movimientoBanco", "P" }
            };

            // Act
            bool guardadoExitoso = cn.GuardarDatos(tabla, valores);

            // Assert
            Assert.True(guardadoExitoso); // Verificar que el guardado fue exitoso
        }

        [Fact]
        public void TestEliminarMovimiento()
        {
            // Arrange
            string tabla = "tbl_movimientodebancos";
            var valores = new Dictionary<string, object>
        {
            { "id_movimientoBanco", "90" },
            { "tipo_movimientoBanco", "1" },
            { "fecha_movimientoBanco", "2024-05-19" },
            { "monto_movimientoBanco", "2000" },
            { "cuenta_movimientoBanco", "1" },
            { "efecto_movimientoBanco", "+" }
        };

            // Inserta el registro si no existe
            cn.GuardarDatos(tabla, valores);

            // Act
            int idMovimientoAEliminar = 90; // ID de movimiento que deseas eliminar
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

       

    }
}
