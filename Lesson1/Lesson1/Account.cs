using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    enum accountType
    {
        Unknown,
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
        private static int id;
        private int _accountNumber;
        private int _balance;
        private accountType _accountType;

        public Account(int _balance) : this(_balance, accountType.Unknown)
        {
        }

        public Account(accountType _accountType) : this(0, _accountType)
        {
        }

        public Account(int _balance, accountType _accountType)
        {
            _accountNumber = SetId();
            this._balance = _balance;
            this._accountType = _accountType;
        }
       
        public int SetId()
        {
            _accountNumber = id++;
            return _accountNumber;
        }

        public void PushToAcc(int money)
        {
            _balance += money;
        }
       
        public void TakeFromAcc(int money)
        {
            if (_balance >= 0 && _balance >= money)
            {
                _balance -= money;
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия");
                Console.WriteLine();
            }
        }
        
        public void PrintAccount()
        {
            Console.WriteLine("Информация о счёте:");
            Console.WriteLine($"Id: {_accountNumber}");
            Console.WriteLine($"Баланс: {_balance}");
            Console.WriteLine($"Тип аккаунта: {_accountType}");
            Console.WriteLine();
        }
    }

    
}
