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
            account.Balance = 1000;
            account.AccountType = accountType.Budget;
            account.AccountNumber = account.SetId();

            var account2 = new Account();
            account2.Balance = 3000;
            account2.AccountType = accountType.Frozen;
            account2.SetId();


            account.PrintAccount();
            account2.PrintAccount();

            Console.ReadLine();
        }
    }
}
