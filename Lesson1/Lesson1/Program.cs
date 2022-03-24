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
            account.SetAccountNumber(1);
            account.SetBalance(1000);
            account.SetType(accountType.Budget);

            account.PrintAccount();

            Console.ReadLine();
        }
    }
}
