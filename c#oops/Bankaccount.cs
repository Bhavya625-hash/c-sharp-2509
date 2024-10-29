using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    internal class Bankaccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be shown");
                }
                balance = value;
            }
        }
        public Bankaccount(string accountNumber,string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0.0m;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ;{amount}, New balance:{balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }
        public void withdrawal(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"withdrawn:{amount},new balance:{balance}");

            }
            else
            {
                Console.WriteLine("invalid amount");
            }

        }
    }
}
