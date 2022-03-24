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
            //Создаём объект
            var account = new Account();
            account.AccountNumber = 1;
            account.Balance = 1000;
            account.AccountType = accountType.Budget;

            //Печатаем инфо
            account.PrintAccount();

            //Кладём деньги на счёт
            account.PushToAcc(3500);

            //Печатаем инфо
            account.PrintAccount();

            //Снимаем со счёта
            account.TakeFromAcc(5000);

            //Выводим инфо
            account.PrintAccount();

            Console.ReadLine();
        }
    }
}
