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
    public partial class ComprasModi : Form
    {
        private string idord = "";
        private string fechaS = "";
        private string fechaE = "";
        private string solicitante = "";
        private string proveedor = "";
        Controlador cn = new Controlador();
        int estadoCompra;
        string estadoCompranumero;
        public ComprasModi()
        {
            InitializeComponent();
            cmb_igualsolicitado.Items.Add("Completa");
            cmb_igualsolicitado.Items.Add("Incompleta");
        }
        public void RecibirDatosDesdeCompraModi(string id)
        {
            string tabla = "tbl_compras";
            string columna = "id_EncComp";
            DataTable tablaMaestra = cn.filtrardatos(tabla, columna, id);
            MostrarDatosEnTextBox(tablaMaestra);
            this.Show();
        }
        public void MostrarDatosEnTextBox(DataTable tabla)
        {
            // Verifica si la tabla tiene al menos una fila
            if (tabla.Rows.Count > 0)
            {
                // Obtiene la primera fila de la tabla
                DataRow fila = tabla.Rows[0];

                // Obtén los valores de los campos y asígnalos a variables
                string id = fila["id_EncComp"].ToString();
                string fechaSolicitud = fila["fechaSolicitid_EncComp"].ToString();
                string fechaEntrega = fila["fechaEntrega_OrdComp"].ToString();
                string depto = fila["deptoSolicitante_EncComp"].ToString();
                string subtotal = fila["subTotal_EncComp"].ToString();
                string iva = fila["iva_EncComp"].ToString();
                string total = fila["totalOrden_EncComp"].ToString();
                string notas = fila["notas_EncComp"].ToString();
                string idprov = fila["tbl_proveedor_id_prov"].ToString();
                string recibido = fila["recibidoIgualSolicitado_EncComp"].ToString();
                string fechaVencimiento = fila["fechaVencimientoPago_EncComp"].ToString();
                string idorden = fila["id_OrdComp"].ToString();

                if (recibido != null)
                {
                    if (recibido.ToString() == "1")
                    {
                        estadoCompranumero = "Completa";
                    }
                    else if (recibido.ToString() == "0")
                    {
                        estadoCompranumero = "Incompleta";
                    }
                }

                // Asigna los valores de las variables a los TextBox en tu formulario
                txt_numcompra.Text = id;
                dateTimePickerPedido.Text = fechaSolicitud;
                dateTimePickerEntrega.Text = fechaEntrega;
                txt_departamentos.Text = depto;
                txt_subtotal.Text = subtotal;
                txt_iva.Text = iva;
                txt_total.Text = total;
                txt_nota.Text = notas;
                txt_Idprov.Text = idprov;
                cmb_igualsolicitado.Text = estadoCompranumero;
                dateTimePickerVencimiento.Text = fechaVencimiento;
                txt_numorden.Text = idorden;
                ObtenerDatosProveedor(idprov);
                actualizardatagridviewCompra(id);
            }
            else
            {
                // Si la tabla está vacía, muestra un mensaje de error o realiza alguna otra acción
                MessageBox.Show("No se encontraron datos para mostrar.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ObtenerDatosProveedor(string proveedorId)
        {
            string nombreProveedor = cn.ObtenerNombreProveedor(proveedorId);
            string domicilioProveedor = cn.ObtenerDomicilioProveedor(proveedorId);
            string telefonoProveedor = cn.ObtenerTelefonoProveedor(proveedorId);
            txt_nombreprov.Text = nombreProveedor;
            txt_domicilio.Text = domicilioProveedor;
            txt_telefonoprov.Text = telefonoProveedor;
        }
        public void actualizardatagridviewCompra(string codigo)
        {
            string tabla = "tbl_detallecompras";
            string campo = "tbl_Encabezado_Compras_id_EncComp";
            DataTable dt = cn.filtrardatos(tabla, campo, codigo);
            // Filtras los datos que deseas mostrar en el DataGridView
            DataTable filteredTable = FiltrarDatos(dt);
            // Asignas el DataTable filtrado como origen de datos del DataGridView
            dgv_detalle.DataSource = filteredTable;
        }
        private DataTable FiltrarDatos(DataTable dt)
        {
            DataTable filteredTable = new DataTable();

            // Agregar las columnas necesarias al DataTable filtrado
            filteredTable.Columns.Add("ID_Detalle", typeof(int));
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
                string nombre = cn.ObtenerNombre(codigoProducto);
                string descripcion = cn.ObtenerDescripcion(codigoProducto);
                decimal precioUnitario = cn.ObtenerPrecioUnitario(codigoProducto);

                // Si se encontraron datos del producto, llenamos las columnas correspondientes en el DataTable filtrado
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion))
                {
                    // Creamos una nueva fila en el DataTable filtrado
                    DataRow newRow = filteredTable.NewRow();
                    // Asignamos los valores a las columnas correspondientes en la nueva fila
                    newRow["ID_Detalle"] = row["id_detalleCompra"];
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

        private void ComprasModi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si el usuario intenta cerrar el formulario, cancela el cierre y oculta el formulario en su lugar
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancela el cierre del formulario
                this.Hide();     // Oculta el formulario en lugar de cerrarlo
            }
        }
        public void RecibirDatosDesdeBuscarOrdenes(string idord, string fechaS, string fechaE, string solicitante, string proveedor)
        {
            // Actualiza los textbox en del formulario con los datos recibidos
            txt_numorden.Text = idord;
            dateTimePickerEntrega.Text = fechaE;
            dateTimePickerPedido.Text = fechaS;
            txt_departamentos.Text = solicitante;
            txt_Idprov.Text = proveedor;
            ObtenerDatosProveedor(proveedor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = txt_numcompra.Text;
            int codigo = int.Parse(num);
            DateTime fechaSolicitud = dateTimePickerPedido.Value;
            DateTime fechaEntrega = dateTimePickerEntrega.Value;
            DateTime fechaVencimiento = dateTimePickerVencimiento.Value;
            string fechas = fechaSolicitud.ToString("yyyy-MM-dd");
            string fechae = fechaEntrega.ToString("yyyy-MM-dd");
            string fechav = fechaVencimiento.ToString("yyyy-MM-dd");
            string subtotals = txt_subtotal.Text;
            string ivas = txt_iva.Text;
            string totals = txt_total.Text;
            double subtotal = Double.Parse(subtotals);
            double iva = Double.Parse(ivas);
            double totalOrden = Double.Parse(totals);
            string prov = txt_Idprov.Text;
            int codigoprov = int.Parse(prov);
            string codigoorden = txt_numorden.Text;
            int codord = int.Parse(codigoorden);
            // Confirmar con el usuario antes de enviar la orden de compra
            DialogResult resultado = MessageBox.Show("¿Está seguro de modificar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Intenta realizar la inserción de la orden y el detalle dentro de una transacción
                try
                {
                    // Actualizar la orden de compra
                    cn.ActualizarCompra(codigo, fechas, fechae, txt_departamentos.Text, subtotal, iva, totalOrden, txt_nota.Text, codigoprov, estadoCompra, fechav, codord);

                    // Iterar sobre cada fila en el DataGridView
                    foreach (DataGridViewRow fila in dgv_detalle.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            int codigoDetalle = int.Parse(fila.Cells["ID_Detalle"].Value.ToString());
                            // Obtener los valores de cantidad, idproducto y totalfila
                            string cantd = fila.Cells[1].Value.ToString();
                            string idprod = fila.Cells[2].Value.ToString();
                            string totfil = fila.Cells[6].Value.ToString();

                            // Verificar que los valores puedan ser convertidos a los tipos de datos necesarios
                            if (int.TryParse(cantd, out int cantidad) && int.TryParse(idprod, out int idproducto) && double.TryParse(totfil, out double totalfila))
                            {
                                // Actualizar el detalle de la orden de compra
                                cn.ActualizarDetalleCompra(codigoDetalle, cantidad, totalfila, idproducto, codigo);
                            }
                        }
                    }
                    MessageBox.Show("Compra modificada correctamente.");
                    Limpiar();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al modificar la compra: " + ex.Message);
                }
            }
        }
        private void Limpiar()
        {
            txt_numcompra.Clear();
            txt_numorden.Clear();
            dateTimePickerPedido.Value = DateTime.Now;
            dateTimePickerEntrega.Value = DateTime.Now;
            dateTimePickerVencimiento.Value = DateTime.Now;
            txt_departamentos.Clear();
            txt_subtotal.Clear();
            txt_iva.Clear();
            txt_total.Clear();
            txt_nota.Clear();
            txt_Idprov.Clear();
            txt_nombreprov.Clear();
            txt_domicilio.Clear();
            txt_telefonoprov.Clear();
            cmb_igualsolicitado.SelectedIndex = -1;
            DataGridViewColumn detalle = dgv_detalle.Columns["ID_Detalle"];
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
            dgv_detalle.Columns.Remove(detalle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dgv_detalle.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaseleccionada = dgv_detalle.SelectedRows[0];

                // Extrae los datos de las celdas de la fila seleccionada
                string cantidad = filaseleccionada.Cells["Cantidad"].Value.ToString();
                string nombre = filaseleccionada.Cells["Nombre"].Value.ToString();
                string descripcion = filaseleccionada.Cells["Descripción"].Value.ToString();
                string preciou = filaseleccionada.Cells["Precio_Unitario"].Value.ToString();
                string fila = filaseleccionada.Cells["Total"].Value.ToString();
                // Repite este proceso para todas las columnas necesarias

                // Abre el otro formulario
                ModificarDetalleCompras formdetalle = new ModificarDetalleCompras(this);
                // Pasa los datos a los TextBoxes en el otro formulario
                formdetalle.txt_cantidadActual.Text = cantidad;
                formdetalle.txt_nombreActual.Text = nombre;
                formdetalle.txt_descripcionActual.Text = descripcion;
                formdetalle.txt_preciouActual.Text = preciou;
                formdetalle.txt_filaActual.Text = fila;

                // Muestra el formulario destino
                formdetalle.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ActualizarDatoEnDataGridView(string cant, string idprod, string nombre, string desc, string preciou, string totf)
        {
            // Actualiza el valor de la celda seleccionada con los nuevos datos
            dgv_detalle.SelectedCells[1].Value = cant;
            dgv_detalle.SelectedCells[2].Value = idprod;
            dgv_detalle.SelectedCells[3].Value = nombre;
            dgv_detalle.SelectedCells[4].Value = desc;
            dgv_detalle.SelectedCells[5].Value = preciou;
            dgv_detalle.SelectedCells[6].Value = totf;

            double subtotal = 0;
            double ivaPorcentaje = 0.12;

            foreach (DataGridViewRow fila in dgv_detalle.Rows)
            {
                // Sirve para asegurarse de que la fila no sea la fila de encabezado.
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

        private void btn_buscarProveedor_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras(idord, fechaS, fechaE, solicitante, proveedor);
            BuscarOrdenCompra buscarOrdenCompra = new BuscarOrdenCompra(compras, this);
            buscarOrdenCompra.Show();
        }

        private void cmb_igualsolicitado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_igualsolicitado.SelectedItem != null)
            {
                if (cmb_igualsolicitado.SelectedItem.ToString() == "Completa")
                {
                    estadoCompra = 1;
                }
                else if (cmb_igualsolicitado.SelectedItem.ToString() == "Incompleta")
                {
                    estadoCompra = 0;
                }
            }
        }
    }
}
