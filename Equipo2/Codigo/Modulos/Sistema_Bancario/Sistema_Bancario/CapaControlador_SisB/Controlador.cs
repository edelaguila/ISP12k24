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

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuentaDeb, string numCuentaCred, string tipoTransaccion, string estado, string valorTrans, string estadoConciliacion)
        {
            sentencias.InsertarMovimiento(valorMovimiento, descripcionMovimiento, numCuentaDeb, numCuentaCred, tipoTransaccion, estado, valorTrans, estadoConciliacion);
        }
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTblMov(tabla);
        }
        public Controlador()
        {
            sentencias = new Sentencias();

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

        public void makeTransaction(string code, int origen, double mont)
        {
            int dest = getAccount(code, origen);
            this.sentencias.makeDepositTransaction(2, origen, mont);
        }

    }
}
