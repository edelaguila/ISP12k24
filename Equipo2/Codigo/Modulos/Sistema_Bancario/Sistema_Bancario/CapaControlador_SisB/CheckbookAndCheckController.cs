using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB.Sentences;
using CapaModelo_SisB.Templates;
using CapaModelo_SisB;

namespace CapaControlador_SisB
{
    public class CheckbookAndCheckController
    {

        public static int getCheckbookId(string accountNo)
        {
            Sentencias sn = new Sentencias();
            Cuenta account = sn.getAccountByNumber(accountNo);
            Console.WriteLine("Account ID");
            Console.WriteLine(account.id);
            Chequera ch = CheckbookSentence.getCheckbookAccount(account.id);
            return ch != null ? ch.Idcuenta : -1;
        }

        public static void createCheckbook(string accountNo)
        {
            Sentencias sn = new Sentencias();
            Cuenta account = sn.getAccountByNumber(accountNo);
            CheckbookSentence.addCheckbookToAccount(account.id);
        }
        public static void generateChecksFromCheckbook(int checkbookId, int cantidad)
        {
            CheckSentence.createChecksFromCheckbook(cantidad, checkbookId);
        }


        public static bool CheckbookContainChecks(int checkbookId)
        {
            return CheckSentence.getChecksFromCheckbook(checkbookId).Count > 0;
        }

        public static void updateCheck(int Id, double amount)
        {
            CheckSentence.updateCheckById(Id, amount);

        }

    }
}
