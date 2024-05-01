using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorERP;

namespace CapaVistaERP.Procesos
{ 
    //Programado por: Carol Chuy
    public partial class FacturaporPagar : Form
    {
        private Controlador controller;
        public FacturaporPagar(string idcompra, string fechaV, string proveedorfact)
        {
            InitializeComponent();
            controller = new Controlador();
            controller.CargarOpcionesOrden(cmb_orden);
            txt_numcompra.Text = idcompra;
            dateTimePickerVencimiento.Text = fechaV;
            txt_Idprov.Text = proveedorfact;
        }
        private void FacturaporPagar_Load(object sender, EventArgs e)
        {
            string tabla = "tbl_facturaxpagar";
            string campoid = "NoFactura";
            txt_numcompra.Enabled = false;
            txt_numfactura.Enabled = false;
            txt_Idprov.Enabled = false;
            btn_numorden.Enabled = false;
            txt_nombreprov.Enabled = false;
            txt_domicilio.Enabled = false;
            txt_telefonoprov.Enabled = false;
            dateTimePickerVencimiento.Enabled = false;
            dateTimePickerAbono.Enabled = false;
            int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            txt_numfactura.Text = ultimoNumeroOrden.ToString();
        }
        public void RecibirDatosDesdeBuscarOrdenes(string idcompra, string fechaV, string proveedorfact, string subtotal, string iva, string total)
        {
            // Actualiza los textbox en del formulario con los datos recibidos
            txt_numcompra.Text = idcompra;
            int numero = int.Parse(idcompra);
            dateTimePickerVencimiento.Text = fechaV;
            txt_Idprov.Text = proveedorfact;
            txt_subtotal.Text = subtotal;
            txt_iva.Text = iva;
            txt_total.Text = total;
            ObtenerDatosProveedor(proveedorfact);
            actualizardatagridviewFactura(numero);
        }
        public void actualizardatagridviewFactura(int codigo)
        {
            DataTable dt = controller.llenarTablasCondicionFactura(codigo);
            // Filtras los datos que deseas mostrar en el DataGridView
            DataTable filteredTable = FiltrarDatos(dt);
            // Asignas el DataTable filtrado como origen de datos del DataGridView
            dgv_detalle.DataSource = filteredTable;
        }
        private DataTable FiltrarDatos(DataTable dt)
        {
            DataTable filteredTable = new DataTable();

            // Agregar las columnas necesarias al DataTable filtrado
            filteredTable.Columns.Add("Cantidad", typeof(int));
            filteredTable.Columns.Add("ID_Producto", typeof(int));
            filteredTable.Columns.Add("Nombre", typeof(string));
            filteredTable.Columns.Add("Descripción", typeof(string));
            filteredTable.Columns.Add("Precio_Unitario", typeof(decimal));
            filteredTable.Columns.Add("Total", typeof(double));

            // Iterar sobre cada fila en el DataTable original
            foreach (DataRow row in dt.Rows)
            {
                string codigoProducto = row["tbl_Producto_cod_producto"].ToString();
                string nombre = controller.ObtenerNombre(codigoProducto);
                string descripcion = controller.ObtenerDescripcion(codigoProducto);
                decimal precioUnitario = controller.ObtenerPrecioUnitario(codigoProducto);

                // Si se encontraron datos del producto, llenamos las columnas correspondientes en el DataTable filtrado
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion))
                {
                    // Creamos una nueva fila en el DataTable filtrado
                    DataRow newRow = filteredTable.NewRow();
                    // Asignamos los valores a las columnas correspondientes en la nueva fila
                    newRow["Cantidad"] = row["cantidad_compra_det"];
                    newRow["ID_Producto"] = row["tbl_Producto_cod_producto"];
                    newRow["Nombre"] = nombre;
                    newRow["Descripción"] = descripcion;
                    newRow["Precio_Unitario"] = precioUnitario;
                    newRow["Total"] = row["totalPorProducto_det"];
                    // Agregamos la nueva fila al DataTable filtrado
                    filteredTable.Rows.Add(newRow);
                }
            }
            // Devolvemos el DataTable filtrado
            return filteredTable;
        }
        private void ObtenerDatosProveedor(string proveedorId)
        {
            string nombreProveedor = controller.ObtenerNombreProveedor(proveedorId);
            string domicilioProveedor = controller.ObtenerDomicilioProveedor(proveedorId);
            string telefonoProveedor = controller.ObtenerTelefonoProveedor(proveedorId);
            string nitProveedor = controller.ObtenerNitProveedor(proveedorId);

            txt_Idprov.Text = proveedorId;
            txt_nombreprov.Text = nombreProveedor;
            txt_domicilio.Text = domicilioProveedor;
            txt_telefonoprov.Text = telefonoProveedor;
            txt_nitprov.Text = nitProveedor;
        }

        private void cmb_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmb_orden.SelectedItem.ToString();

            // Si se selecciona "Directa", deshabilitar botones para buscar proveedor
            if (seleccion == "Directa")
            {
                btn_numorden.Enabled = false;
                txt_numcompra.Enabled = true;
                txt_Idprov.Enabled = true;
                txt_nombreprov.Enabled = true;
                txt_domicilio.Enabled = true;
                txt_telefonoprov.Enabled = true;
                txt_nitprov.Enabled = true;
                dateTimePickerVencimiento.Enabled = true;
                dateTimePickerAbono.Enabled = true;
                // Añadir las columnas con los encabezados deseados
                dgv_detalle.Columns.Add("Cantidad", "Cantidad");
                dgv_detalle.Columns.Add("ID_Producto", "ID_Producto");
                dgv_detalle.Columns.Add("Nombre", "Nombre");
                dgv_detalle.Columns.Add("Descripcion", "Descripción");
                dgv_detalle.Columns.Add("Precio_Unitario", "Precio_unitario");
                dgv_detalle.Columns.Add("Total", "Total");
            }

            // Si se selecciona "Relacionada", deshabilitar TextBox para ingresar directamente
            if (seleccion == "Relacionada")
            {
                btn_numorden.Enabled = true;
                txt_numcompra.Enabled = false;
                txt_Idprov.Enabled = false;
                txt_nombreprov.Enabled = false;
                txt_domicilio.Enabled = false;
                txt_telefonoprov.Enabled = false;
                txt_nitprov.Enabled = false;
                dateTimePickerVencimiento.Enabled = false;
                dateTimePickerAbono.Enabled = true;
                btn_agregar.Enabled = false;
                btn_confirmar.Enabled = false;
                btn_eliminar.Enabled = false;
                dgv_detalle.Columns.Clear();
            }
        }

        private void btn_numorden_Click(object sender, EventArgs e)
        {
            BuscarCompras BuscarCompras = new BuscarCompras(this);
            BuscarCompras.Show();
        }
    }
}
