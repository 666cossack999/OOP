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
            var account = new Account();
            account.AccountNumber = 1;
            account.Balance = 1000;
            account.AccountType = accountType.Budget;

            account.PrintAccount();

            Console.ReadLine();
        }
    }
}
