using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        /// <summary>
        /// Выводит строку задом-наперёд
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>перевёрнутая строка</returns>
        static string StringRevers(string str)
        {
            return new string(str.Reverse().ToArray());
        }

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

            //переворачиваем строку
            string myStr = StringRevers("Улыбок тебе дед Макар");

            Console.WriteLine(myStr);

            Console.ReadLine();
        }

        
    }
}
