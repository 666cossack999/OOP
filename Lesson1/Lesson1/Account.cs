using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    enum accountType
    {
        Budget,
        ForeignСurrency,
        Frozen,
        Insured,
        Checking,
        Correspondent,
        Savings
    }

    class Account
    {
        private static int _accountNumber;
        private static int _balance;
        private static accountType _accountType;

        public void SetAccountNumber(int id)
        {
            _accountNumber = id;
        }

        public int GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetBalance(int balance)
        {
            _balance = balance;
        }

        public int GetBalance()
        {
            return _balance;
        }

        public void SetType(accountType type)
        {
            _accountType = type;
        }

        public accountType GetType()
        {
            return _accountType;
        }

        public void PrintAccount()
        {
            Console.WriteLine("Информация о счёте:");
            Console.WriteLine($"Id: {_accountNumber}");
            Console.WriteLine($"Баланс: {_balance}");
            Console.WriteLine($"Тип аккаунта: {_accountType}");
        }
    }

    
}
