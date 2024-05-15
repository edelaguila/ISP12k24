using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB;
using CapaModelo_SisB.Templates;
using System.Data;

namespace CapaControlador_SisB
{
    public class Controlador
    {

        private Sentencias sentencias;

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuentaDeb, string numCuentaCred, string estado)
        {
            sentencias.InsertarMovimiento(valorMovimiento, descripcionMovimiento, numCuentaDeb, numCuentaCred, estado);
        }
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTblMov(tabla);
        }

        public DataTable llenarHistorial(string tabla, int id)
        {
            return sentencias.llenarHistorial(tabla, id);
            
            
        }
        public Controlador()
        {
            sentencias = new Sentencias();

        }

        public string[] items(string tabla, string campo1, string campo2, int id)
        {
            string[] Items = sentencias.llenarCmb(tabla, campo1, campo2, id);

            return Items;


        }

        ///Controlador 2///

        public DataTable enviar(string tabla, string campo1, string campo2, int id)
        {



            var dt1 = sentencias.obtener(tabla, campo1, campo2, id);

            return dt1;
        }

        public DataTable ObtenerTipoDeTransacciones()
        {
            return sentencias.TipoTransaccionBancaria();

        }

        public DataTable valorTrans()
        {
            return sentencias.valorTransaccion();

        }

        public int ObtenerValorTransaccion(string tipoTransaccion)
        {
            return sentencias.ObtenerValorTransaccion(tipoTransaccion);
        }


        public void saveFriendAccount(string code, int referenceAcc)
        {
            this.sentencias.addFriendAccount(referenceAcc, code);
        }


        public int getAccountId(int UserId)
        {
            return this.sentencias.getCurrentAccount(UserId).id;
        }

        public int getAccount(string code, int referenceID)
        {
            List<CuentaAmiga> accounts = this.sentencias.getFriendAccount(referenceID);
            foreach (CuentaAmiga ac in accounts)
            {
                if (ac.numero.Equals(code))
                {
                    return ac.id;
                }
            }
            return -1;
        }

        public Cuenta getCurrentAccount(int Id)
        {
            return this.sentencias.getCurrentAccount(Id);
        }

        public void makeTransaction(string code, int origen, double mont)
        {
            int dest = getAccount(code, origen);
            this.sentencias.makeDepositTransaction(2, origen, mont);
        }

    }
}
