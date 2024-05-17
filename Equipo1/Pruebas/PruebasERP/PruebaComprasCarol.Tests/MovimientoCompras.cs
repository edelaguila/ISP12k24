using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CapaControladorERP;

namespace PruebaComprasCarol.Tests
{
    public class MovimientoCompras
    {
        Controlador con = new Controlador();
        [Fact]
        public void EliminarDetalleOrdenCompra()
        {
            // Arrange
            int idDetalleAEliminar = 6; // ID del detalle que deseas eliminar

            // Act
            bool eliminacionExitosa; // Variable para almacenar el resultado

            try
            {
                con.EliminarDetalleOrdenCompra(idDetalleAEliminar);
                eliminacionExitosa = true; // Si la ejecución no genera excepciones, se considera exitosa
            }
            catch
            {
                eliminacionExitosa = false; // Si se produce una excepción, se considera fallida
            }

            // Assert
            Assert.True(eliminacionExitosa);
        }
        [Fact]
        public void EliminarDetalleCompra()
        {
            // Arrange
            int idDetalleAEliminar = 6; // ID del detalle que deseas eliminar

            // Act
            bool eliminacionExitosa; // Variable para almacenar el resultado

            try
            {
                con.EliminarDetalleCompra(idDetalleAEliminar);
                eliminacionExitosa = true; // Si la ejecución no genera excepciones, se considera exitosa
            }
            catch
            {
                eliminacionExitosa = false; // Si se produce una excepción, se considera fallida
            }

            // Assert
            Assert.True(eliminacionExitosa);
        }
        [Fact]
        public void EliminarDetalleFactura()
        {
            // Arrange
            int idDetalleAEliminar = 6; // ID del detalle que deseas eliminar

            // Act
            bool eliminacionExitosa; // Variable para almacenar el resultado

            try
            {
                con.EliminarDetalleFactura(idDetalleAEliminar);
                eliminacionExitosa = true; // Si la ejecución no genera excepciones, se considera exitosa
            }
            catch
            {
                eliminacionExitosa = false; // Si se produce una excepción, se considera fallida
            }

            // Assert
            Assert.True(eliminacionExitosa);
        }
        [Fact]
        public void InsertarCompra()
        {
            // Arrange
            int codigo = 70;
            string fechas = "2024-05-20";
            string fechae = "2024-05-21";
            string depa = "Compras";
            double subtotal = 100.0;
            double iva = 15.0;
            double totalCompra = 115.0;
            string notas = "Notas de la compra";
            int codigoprov = 2;
            int estadoCompra = 1;
            string fechap = "2024-05-25";
            int codorden = 3;

            // Act
            bool insercionExitosa;

            try
            {
                con.InsertarCompra(codigo, fechas, fechae, depa, subtotal, iva, totalCompra, notas, codigoprov, estadoCompra, fechap, codorden);
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
        public void InsertarOrdenCompra()
        {
            // Arrange
            int codigo = 70;
            string fechas = "2024-05-20";
            string fechae = "2024-05-21";
            string deptoSolicitante = "Departamento de Compras";
            double subTotal = 500.0;
            double iva = 12.0;
            double totalOrden = subTotal + (subTotal * iva / 100);
            string notas = "Notas de la orden de compra";
            int proveedorId = 2; // Replace with an actual provider ID for testing

            // Act
            bool insercionExitosa;

            try
            {
                con.InsertarOrdenCompra(codigo, fechas, fechae, deptoSolicitante, subTotal, iva, totalOrden, notas, proveedorId);
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
        public void InsertarFactura()
        {
            // Arrange
            int noFactura = 70; // Replace with a unique invoice number
            string nombreProveedor = "Proveedor XYZ";
            string nitProveedor = "123456789012345";
            string fechav = "2024-05-20";
            string fechaa = "2024-05-21";
            double subTotal = 750.0;
            double iva = 18.0;
            double totalFactura = subTotal + (subTotal * iva / 100);
            int estadoPago = 1; // Assuming 1 represents an unpaid status
            string notas = "Notas de la factura";
            int idEncabezadoCompra = 3; // Replace with a valid ID from the tbl_Encabezado_Compras table

            // Act
            bool insercionExitosa;

            try
            {
                con.InsertarFactura(noFactura, nombreProveedor, nitProveedor, fechav, fechaa, subTotal, iva, totalFactura, estadoPago, notas, idEncabezadoCompra);
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
