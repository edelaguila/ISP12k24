using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB.Libraries;
using CapaModelo_SisB.Templates;
using CapaModelo_SisB.Sentences;
using CapaModelo_SisB;

namespace CapaControlador_SisB
{
    public class TransactionController
    {
        public static void makeTransaction(string accountNo, double amount, int sign = 1)
        {
            Sentencias sn = new Sentencias();
            Cuenta account = sn.getAccountByNumber(accountNo);
            TransactionSentences.updateBalanceFromAccount(account.id, amount * sign);
            HistorySentence.saveTransactionOnHistory(account.id, sign == 1 ? "Deposito" : "Retiro", amount);
        }

        public static bool accountCanPay(int accountId, double amount)
        {
            return TransactionSentences.canPay(accountId, amount);
        }
    }
}
