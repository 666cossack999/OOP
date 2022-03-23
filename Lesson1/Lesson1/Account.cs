using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Account
    {
        private int accountNumber;
        private int balance;

        private enum accountType
        {
            Budget,
            ForeignСurrency,
            Frozen,
            Insured,
            Checking,
            Correspondent,
            Savings
        }

        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                this.accountNumber = value;
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

        public int AccountType
        {
            get
            {
                return this.AccountType;
            }
        }


    }

    
}
