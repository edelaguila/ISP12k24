using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo_SisB;
using CapaModelo_SisB.Templates;

namespace CapaControlador_SisB
{
    public class WidgetHelper
    {

        public DataProvider provider;
        public WidgetHelper()
        {
            this.provider = new DataProvider();
        }

        public void fillCliente(ComboBox cmb)
        {
            List<Cliente> clientes = this.provider.getClientes();
            foreach (Cliente cl in clientes)
            {
                cmb.Items.Add(cl.nombre);
            }
        }

        public void fillMoneda(ComboBox cmb)
        {
            List<Moneda> monedas = this.provider.getMonedas();
            foreach (Moneda moneda in monedas)
            {
                cmb.Items.Add(moneda.name);
            }
        }
        public void fillTipoCuenta(ComboBox cmb)
        {
            List<TipoCuenta> tcuentas = this.provider.getTiposCuentas();
            foreach (TipoCuenta cuenta in tcuentas)
            {
                cmb.Items.Add(cuenta.name);
            }
        }

        public void ComboFiller(ComboBox cmb, string tablename)
        {
            List<string> rows = this.provider.getSingleRowValues(tablename);
            foreach (string row in rows) cmb.Items.Add(row);
        }
    }
}



