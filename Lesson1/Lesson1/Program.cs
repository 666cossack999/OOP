using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём объекты
            var account = new Account(1000);
            var account2 = new Account(3000, accountType.Budget);
            var account3 = new Account(accountType.Savings);



            //Выводим инфо
            account.PrintAccount();
            account2.PrintAccount();
            account3.PrintAccount();

            //переводим средства со счёта account2 на счёт account
            account.CashTransfer(account2, 1500);

            account.PrintAccount();
            account2.PrintAccount();

            Console.ReadLine();
        }
    }
}
