using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oops
{
    public class banks
    {
        private List<Customer> customers;

        // Constructor to initialize the customer list
        public banks()
        {
            customers = new List<Customer>();
        }

        // Method to add a customer to the bank
        public void AddCustomer(string name)
        {
            var customer = new Customer(name);
            customers.Add(customer);
            Console.WriteLine($"Added customer: {name}");
        }

        // Method to add an account to a customer
        public void AddAccount(string customerName, string accountNumber, double initialBalance)
        {
            var customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                customer.AddAccount(accountNumber, initialBalance);
            }
            else
            {
                Console.WriteLine($"Customer {customerName} not found.");
            }
        }

        // Method to display all customer details with their accounts
        public void DisplayCustomerDetails()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"\nCustomer Name: {customer.Name}");
                customer.DisplayAccounts();
            }
        }

        // Nested Customer class
        public class Customer
        {
            public string Name { get; set; }
            private List<Account> accounts;

            // Constructor for Customer
            public Customer(string name)
            {
                Name = name;
                accounts = new List<Account>();
            }

            // Method to add an account to the customer
            public void AddAccount(string accountNumber, double initialBalance)
            {
                var account = new Account(accountNumber, initialBalance);
                accounts.Add(account);
                Console.WriteLine($"Added account {accountNumber} for customer {Name} with balance {initialBalance:C}");
            }

            // Method to display accounts of the customer
            public void DisplayAccounts()
            {
                if (accounts.Count == 0)
                {
                    Console.WriteLine("No accounts found.");
                    return;
                }

                foreach (var account in accounts)
                {
                    Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance:C}");
                }
            }

            // Nested Account class
            public class Account
            {
                public string AccountNumber { get; set; }
                public double Balance { get; set; }

                // Constructor for Account
                public Account(string accountNumber, double balance)
                {
                    AccountNumber = accountNumber;
                    Balance = balance;
                }
            }
        }
    }
}
