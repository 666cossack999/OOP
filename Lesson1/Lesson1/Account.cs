using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    /// <summary>
    /// Тип счёта
    /// </summary>
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
       
        /// <summary>
        /// Создаёт уникальный ID
        /// </summary>
        /// <returns></returns>
        public int SetId()
        {
            _accountNumber = id++;
            return _accountNumber;
        }
       
        /// <summary>
        /// Положить деньги на счёт
        /// </summary>
        /// <param name="money">Сумма</param>
        public void PushToAcc(int money)
        {
            _balance += money;
        }
        
        /// <summary>
        /// Снять деньги со счёта
        /// </summary>
        /// <param name="money"></param>
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
        
        /// <summary>
        /// Вывести инфо о счёте
        /// </summary>
        public void PrintAccount()
        {
            Console.WriteLine("Информация о счёте:");
            Console.WriteLine($"Id: {_accountNumber}");
            Console.WriteLine($"Баланс: {_balance}");
            Console.WriteLine($"Тип аккаунта: {_accountType}");
            Console.WriteLine();
        }

        /// <summary>
        /// Переводит сумму с одного счёта на другой
        /// </summary>
        /// <param name="account">С какого счёта списать</param>
        /// <param name="cash">сумма</param>
        public void CashTransfer(Account account, int cash)
        {
            if (account._balance >= 0 && account._balance >= cash)
            {
                account._balance -= cash;
                this._balance += cash;
            } else
            {
                Console.WriteLine("Недостаточно средств для перевода");
            }
        }

        
    }

    
}
