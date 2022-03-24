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
        private static int id = 1;
        private int _accountNumber;
        private int _balance;
        private accountType _accountType;

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                this._accountNumber = value;
            }
        }

        public int Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }

        public accountType AccountType
        {
            get
            {
                return this._accountType;
            }
            set
            {
                this._accountType = value;
            }
        }

        public int SetId()
        {
            _accountNumber = id++;
            return _accountNumber;
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
