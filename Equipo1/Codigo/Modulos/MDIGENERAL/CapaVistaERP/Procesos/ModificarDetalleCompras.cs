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
    public partial class ModificarDetalleCompras : Form
    {
        private Controlador cn = new Controlador();
        private ComprasModi ComprasModi;
        public ModificarDetalleCompras(ComprasModi comprasModi)
        {
            InitializeComponent();
            ComprasModi = comprasModi;
            llenarprod();
        }
        public void llenarprod()
        {
            cmb_productos.ValueMember = "numero";
            cmb_productos.DisplayMember = "nombre";

            string[] items = cn.itemsprod();

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
            var dt2 = cn.enviarprod();
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
                string descripcion = cn.ObtenerDescripcion(selectedProductId);
                decimal precioUnitario = cn.ObtenerPrecioUnitario(selectedProductId);

                // Llena los TextBox con la descripción y el precio unitario
                txt_descripcionNuevo.Text = descripcion;
                txt_preciouNuevo.Text = precioUnitario.ToString();

                //Pasa lo que está dentro de los text box a double para poder sacar el total de la fila
                double precioU = double.TryParse(txt_preciouNuevo.Text, out double precio) ? precio : 0.0;
                int cantidad = int.TryParse(txt_cantidadNuevo.Text, out int cant) ? cant : 0;
                double totalprod = precioU * cantidad;
                txt_totalfilaNuevo.Text = totalprod.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Obtener el ID del producto que seleccionó el usuario
            string selectedValue = cmb_productos.SelectedItem.ToString();
            // Divide la cadena para tener ambos campos
            string[] parts = selectedValue.Split('-');
            string selectedProductId = parts[0].Trim();
            string selectedName = parts[1].Trim();

            string cant = txt_cantidadNuevo.Text;
            string idprod = selectedProductId;
            string nombre = selectedName;
            string desc = txt_descripcionNuevo.Text;
            string preciou = txt_preciouNuevo.Text;
            string totf = txt_totalfilaNuevo.Text;
            ComprasModi.ActualizarDatoEnDataGridView(cant, idprod, nombre, desc, preciou, totf);
            this.Close();
        }
    }
}
