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
        private int accountNumber;
        private int balance;
        private accountType accountType;

        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                this.accountNumber++;
            }
        }

        public int Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public accountType AccountType
        {
            get
            {
                return this.accountType;
            }
            set
            {
                this.accountType = value;
            }
        }
        
        public void PushToAcc(int money)
        {
            balance += money;
        }
        public void TakeFromAcc(int money)
        {
            if (balance >= 0 && balance >= money)
            {
                balance -= money;
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
            Console.WriteLine($"Id: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип аккаунта: {accountType}");
            Console.WriteLine();
        }
    }

    
}
