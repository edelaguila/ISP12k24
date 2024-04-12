using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB.Templates;

namespace CapaModelo_SisB
{
    public class DataProvider : Provider
    {

        public List<Cliente> clientes;
        public List<Moneda> monedas;
        public List<TipoCuenta> tcuentas;
        public DataProvider()
        {
            this.clientes = new List<Cliente>();
            this.monedas = new List<Moneda>();
            this.tcuentas = new List<TipoCuenta>();
            this._init();
        }

        public void _init()
        {
            this.clientes = this.getClientes();
            this.monedas = this.getMonedas();
            this.tcuentas = this.getTiposCuentas();
        }

    }
}
