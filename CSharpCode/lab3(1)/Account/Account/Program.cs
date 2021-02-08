using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string acName;
        private string acid;
        private int balance;

        public Account()
        {
            Console.WriteLine("Empty Account Object Created");
            balance = 0;
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("{0} is Deposited. Your new Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Entered amount is invalid!");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("{0} is Withdrawed.New Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }

        public string AcName
        {
            set
            {
                acName = value;
            }
            get
            {
                return acName;
            }
        }

        public string Acid
        {
            set
            {
                acid = value;
            }
            get
            {
                return acid;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
        }
    }
}