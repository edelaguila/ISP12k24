using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            llenarprod();
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
            txt_nitprov.Enabled = false;
            btn_agregar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_confirmar.Enabled = false;
            button4.Enabled = false;
            dateTimePickerVencimiento.Enabled = false;
            dateTimePickerAbono.Enabled = false;
            txt_cantidad.Enabled = false;
            cmb_productos.Enabled = false;
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
            if (cmb_orden != null && cmb_orden.SelectedIndex >= 0)
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
                txt_cantidad.Enabled = true;
                cmb_productos.Enabled = true;
                button4.Enabled = true;
                btn_agregar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_confirmar.Enabled = true;
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
                button4.Enabled = true;
                txt_cantidad.Enabled = false;
                cmb_productos.Enabled = false;
                dgv_detalle.Columns.Clear();
            }
            }
        }

        private void btn_numorden_Click(object sender, EventArgs e)
        {
            BuscarCompras BuscarCompras = new BuscarCompras(this);
            BuscarCompras.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            double precioU = 0;
            double cantidad = 0;
            double totalprod = 0;

            // Obtener el precio unitario desde el textbox
            if (double.TryParse(txt_preciou.Text, out precioU))
            {
                // Obtener la cantidad desde el textbox
                if (double.TryParse(txt_cantidad.Text, out cantidad))
                {
                    // Calcular el total del producto
                    totalprod = precioU * cantidad;

                    // Obtener el ID del producto seleccionado en el ComboBox
                    string productoSeleccionado = cmb_productos.SelectedItem.ToString();
                    string[] parts = productoSeleccionado.Split('-');
                    string idProducto = parts[0].Trim();
                    //Obtener el nombre del producto
                    string nomProducto = parts[1].Trim();
                    //Obtener la descripcion del producto
                    string descripcion = txt_descripcion.Text;
                    // Agregar una fila al DataGridView con los detalles
                    dgv_detalle.Rows.Add(cantidad, idProducto, nomProducto, descripcion, precioU, totalprod);
                    //Limpiar los textbox para poder ingresar uno nuevo
                    txt_cantidad.Text = "";
                    cmb_productos.Text = "";
                    txt_descripcion.Text = "";
                    txt_preciou.Text = "";
                    txt_totalfila.Text = "";
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un precio unitario válido.");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_detalle.SelectedRows.Count > 0)
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Obtiene la fila seleccionada del dgv_detalle (datagrid)
                    DataGridViewRow filaSeleccionada = dgv_detalle.SelectedRows[0];

                    // Elimina la fila seleccionada por el usuario
                    dgv_detalle.Rows.Remove(filaSeleccionada);
                }
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea confirmar la orden?", "Confirmación de orden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgv_detalle.Enabled = false;
                txt_cantidad.Enabled = false;
                txt_descripcion.Enabled = false;
                cmb_productos.Enabled = false;
                txt_totalfila.Enabled = false;
                txt_preciou.Enabled = false;

                double subtotal = 0;
                double ivaPorcentaje = 0.12;

                foreach (DataGridViewRow fila in dgv_detalle.Rows)
                {
                    // Se asegura de que la fila no sea la fila de encabezado.
                    if (!fila.IsNewRow)
                    {
                        // Obtiene el valor de la última celda de la fila.
                        double valorCelda;
                        if (double.TryParse(fila.Cells[dgv_detalle.ColumnCount - 1].Value.ToString(), out valorCelda))
                        {
                            // Suma el valor al subtotal.
                            subtotal += valorCelda;
                        }
                    }
                }
                // Calcula el total con IVA.
                double totalIva = (subtotal * (1 + ivaPorcentaje)) - subtotal;
                double total = totalIva + subtotal;

                //Muestra los resultados en los textbox
                txt_subtotal.Text = subtotal.ToString();
                txt_iva.Text = totalIva.ToString();
                txt_total.Text = total.ToString();
            }
        }

        public void llenarprod()
        {
            cmb_productos.ValueMember = "numero";
            cmb_productos.DisplayMember = "nombre";

            string[] items = controller.itemsprod();

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        cmb_productos.Items.Add(items[i]);
                    }
                }

            }
            //Funciona para buscar en el combobox
            var dt2 = controller.enviarprod();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row["cod_producto"]) + "-" + Convert.ToString(row["nombre_prod"]));
                coleccion.Add(Convert.ToString(row["nombre_prod"]) + "-" + Convert.ToString(row["cod_producto"]));
            }
            cmb_productos.AutoCompleteCustomSource = coleccion;
            cmb_productos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_productos.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tabla = "tbl_detallefacturaxpagar";
            string campoid = "id_detalleFac";

            // Verifica que los campos de número de compra, código de proveedor y número de orden sean válidos
            if (int.TryParse(txt_numfactura.Text, out int codigo) &&
                int.TryParse(txt_numcompra.Text, out int codcompra))
            {
                // Verifica que el código de proveedor sea válido
                if (!ValidarCompra())
                {
                    MessageBox.Show("Los datos de la órden no coinciden con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarProveedor())
                {
                    MessageBox.Show("Los datos del proveedor no coinciden con la base de datos o el código de proveedor no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica si la descripción de la orden de compra está vacía
                if (dgv_detalle.RowCount < 2)
                {
                    MessageBox.Show("Por favor, llene la descripción de la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica los campos opcionales (subtotal, IVA y total)
                double subtotal, iva, totalOrden;
                if (double.TryParse(txt_subtotal.Text, out subtotal) &&
                    double.TryParse(txt_iva.Text, out iva) &&
                    double.TryParse(txt_total.Text, out totalOrden))
                {
                    // Resto del código para insertar la compra
                    DateTime fechaVencimiento = dateTimePickerVencimiento.Value;
                    DateTime fechaAbono = dateTimePickerAbono.Value;
                    string fechaV = fechaVencimiento.ToString("yyyy-MM-dd");
                    string fechaA = fechaAbono.ToString("yyyy-MM-dd");
                    int estado = 0;
                    // Confirmar con el usuario antes de enviar la orden de compra
                    DialogResult resultado = MessageBox.Show("¿Está seguro de enviar la factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Intenta realizar la inserción de la orden y el detalle dentro de una transacción
                        try
                        {
                            controller.InsertarFactura(codigo, txt_nombreprov.Text, txt_nitprov.Text, fechaV, fechaA, subtotal, iva, totalOrden, estado, txt_notas.Text, codcompra);
                            foreach (DataGridViewRow fila in dgv_detalle.Rows)
                            {
                                if (!fila.IsNewRow)
                                {
                                    int ultimoNumeroFactura = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
                                    string cantd = fila.Cells[0].Value.ToString();
                                    string idprod = fila.Cells[1].Value.ToString();
                                    string totfil = fila.Cells[5].Value.ToString();

                                    if (int.TryParse(cantd, out int cantidad) && int.TryParse(idprod, out int idproducto) && double.TryParse(totfil, out double totalfila))
                                    {
                                        controller.InsertarDetalleFactura(ultimoNumeroFactura, cantidad, totalfila, codigo, idproducto);
                                    }
                                }
                            }

                            MessageBox.Show("Factura registrada correctamente.");
                            LimpiarCampos();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Eror esss: " + ex.Message);
                            MessageBox.Show("ErrorRRR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void LimpiarCampos()
        {
            string tabla = "tbl_facturaxpagar";
            string campoid = "NoFactura";
            int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            txt_numfactura.Text = ultimoNumeroOrden.ToString();
            txt_numcompra.Clear();
            txt_Idprov.Clear();
            txt_nombreprov.Clear();
            txt_domicilio.Clear();
            txt_telefonoprov.Clear();
            txt_nitprov.Clear();
            dateTimePickerAbono.Value = DateTime.Now; // Restablece la fecha actual
            dateTimePickerVencimiento.Value = DateTime.Now; // Restablece la fecha actual
            txt_subtotal.Clear();
            txt_iva.Clear();
            txt_total.Clear();
            txt_notas.Clear();
            cmb_orden.SelectedIndex = -1;
            cmb_productos.SelectedIndex = -1;
            txt_numcompra.Enabled = false;
            txt_Idprov.Enabled = false;
            btn_numorden.Enabled = false;
            txt_nombreprov.Enabled = false;
            txt_domicilio.Enabled = false;
            txt_telefonoprov.Enabled = false;
            dateTimePickerVencimiento.Enabled = false;
            dateTimePickerAbono.Enabled = false;
            dgv_detalle.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_descripcion.Enabled = false;
            cmb_productos.Enabled = false;
            txt_totalfila.Enabled = false;
            txt_preciou.Enabled = false;
            DataGridViewColumn Cant = dgv_detalle.Columns["Cantidad"];
            DataGridViewColumn Nom = dgv_detalle.Columns["Nombre"];
            DataGridViewColumn des = dgv_detalle.Columns["Descripción"];
            DataGridViewColumn pre = dgv_detalle.Columns["Precio_Unitario"];
            DataGridViewColumn to = dgv_detalle.Columns["Total"];
            DataGridViewColumn id = dgv_detalle.Columns["ID_Producto"];
            dgv_detalle.Columns.Remove(Cant);
            dgv_detalle.Columns.Remove(Nom);
            dgv_detalle.Columns.Remove(des);
            dgv_detalle.Columns.Remove(pre);
            dgv_detalle.Columns.Remove(to);
            dgv_detalle.Columns.Remove(id);
        }

        private bool ValidarCompra()
        {
            if (int.TryParse(txt_numcompra.Text, out int idCompra))
            {
                DataTable ordenData = controller.ObtenerFactPorID(idCompra);

                if (ordenData.Rows.Count > 0)
                {
                    DateTime fechaVencimientoBD = (DateTime)ordenData.Rows[0]["fechaVencimientoPago_EncComp"];
                    string fechaV = dateTimePickerVencimiento.Value.ToString("yyyy-MM-dd");

                    DateTime fechaVencimientoIngresada = DateTime.ParseExact(fechaV, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    if (fechaVencimientoBD == fechaVencimientoIngresada)
                    {
                        return true;
                    }
                    else
                    {
                        // Los datos ingresados no coinciden con los datos de la orden.
                        MessageBox.Show("Los datos ingresados no coinciden con los de la compra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    // La orden no se encontró en la base de datos.
                    MessageBox.Show("El código de compra no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código de compra válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidarProveedor()
        {
            if (int.TryParse(txt_Idprov.Text, out int idProveedor))
            {
                DataTable proveedorData = controller.ObtenerProveedorPorID(idProveedor);

                if (proveedorData.Rows.Count > 0)
                {
                    string nombreProveedor = proveedorData.Rows[0]["nombre_prov"].ToString();
                    string domicilioProveedor = proveedorData.Rows[0]["domicilio_prov"].ToString();
                    string telefonoProveedor = proveedorData.Rows[0]["telefono_prov"].ToString();

                    string nombreIngresado = txt_nombreprov.Text;
                    string domicilioIngresado = txt_domicilio.Text;
                    string telefonoIngresado = txt_telefonoprov.Text;

                    if (nombreProveedor == nombreIngresado && domicilioProveedor == domicilioIngresado && telefonoProveedor == telefonoIngresado)
                    {
                        return true;
                    }
                    else
                    {
                        // Los datos ingresados no coinciden con los datos del proveedor.
                        MessageBox.Show("Los datos ingresados no coinciden con los del proveedor en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    // El proveedor no se encontró en la base de datos.
                    MessageBox.Show("El código de proveedor no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código de proveedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cmb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_productos != null && cmb_productos.SelectedIndex >= 0)
            {
                // Obtener el ID del producto que seleccionó el usuario
                string selectedValue = cmb_productos.SelectedItem.ToString();

                // Divide la cadena para tener ambos campos
                string[] parts = selectedValue.Split('-');
                string selectedProductId = parts[0].Trim();

                // Llamar a la capa controlador a su método ObtenerDescripción y ObtenerPrecioUnitario
                string descripcion = controller.ObtenerDescripcion(selectedProductId);
                decimal precioUnitario = controller.ObtenerPrecioUnitario(selectedProductId);

                // Llena los TextBox con la descripción y el precio unitario
                txt_descripcion.Text = descripcion;
                txt_preciou.Text = precioUnitario.ToString();

                //Pasa lo que está dentro de los text box a double para poder sacar el total de la fila
                double precioU = double.TryParse(txt_preciou.Text, out double precio) ? precio : 0.0;
                int cantidad = int.TryParse(txt_cantidad.Text, out int cant) ? cant : 0;
                double totalprod = precioU * cantidad;
                txt_totalfila.Text = totalprod.ToString();
            }
        }
    }
}
