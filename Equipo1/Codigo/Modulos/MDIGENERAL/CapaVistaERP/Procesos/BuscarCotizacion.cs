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
    public partial class BuscarCotizacion : Form
    {
        Controlador cn = new Controlador();
        public BuscarCotizacion()
        {
            InitializeComponent();
        }


        //dataGridView1.DataSource = cn.Buscar("tbl_cotizaciones", "No_Cotizacion", coti);
        //dataGridView2.DataSource = cn.Buscar("tbl_detalle_cotizacion", "tbl_cotizaciones_No_Cotizacion", coti);
        private void btn_buscarCoti_Click(object sender, EventArgs e)
        {
            string coti = txt_NoCoti.Text;
            //Metodo buscar creditos a Carlos Guzman
            DataTable cotizaciones = cn.Buscar("vista_cotizaciones", "NoCotizacion", coti);
            DataTable detalleCoti = cn.Buscar("tbl_detalle_cotizacion", "tbl_cotizaciones_No_Cotizacion", coti);

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                foreach (DataColumn column in cotizaciones.Columns)
                {
                    dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                }
            }

            if (dataGridView2.Columns.Count == 0)
            {
                foreach (DataColumn column in detalleCoti.Columns)
                {
                    if (column.ColumnName != "id_detalle_cotizacion" &&
                        column.ColumnName != "tbl_clientes_id_cliente" &&
                        column.ColumnName != "tbl_cotizaciones_No_Cotizacion")
                    {
                        dataGridView2.Columns.Add(column.ColumnName, column.ColumnName);
                    }
                }
            }

            if (cotizaciones.Rows.Count > 0)
            {
                foreach (DataRow row in cotizaciones.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("Cotizacion no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (detalleCoti.Rows.Count > 0)
            {
                foreach (DataRow row in detalleCoti.Rows)
                {
                    List<object> rowData = new List<object>();

                    foreach (DataColumn column in detalleCoti.Columns)
                    {
                        if (column.ColumnName != "id_detalle_cotizacion" &&
                            column.ColumnName != "tbl_clientes_id_cliente" &&
                            column.ColumnName != "tbl_cotizaciones_No_Cotizacion")
                        {
                            if (column.ColumnName == "tbl_producto_cod_producto")
                            {
                                int productId = Convert.ToInt32(row["tbl_producto_cod_producto"]);
                                DataTable result = cn.BuscarDato("nombre_prod", "tbl_producto", "cod_producto", productId);
                                string nombreProd = string.Empty;
                                if (result.Rows.Count > 0)
                                {
                                    nombreProd = result.Rows[0]["nombre_prod"].ToString();
                                }

                                rowData.Add(nombreProd);
                            }
                            else
                            {
                                rowData.Add(row[column.ColumnName]);
                            }
                        }
                    }
                    dataGridView2.Rows.Add(rowData.ToArray());
                }
            }
        }

        private void btn_Hacer_pedido_Click(object sender, EventArgs e)
        {
            int idCoti = Convert.ToInt32(txt_NoCoti.Text);

            cn.ActCoti(idCoti);
            MessageBox.Show("Pedido realizado");
        }
    }
}
