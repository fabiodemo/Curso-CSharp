using System;
using AbstractClass.Entities;
using System.Globalization;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Não pode instanciar do tipo Abstract
            //Account acc1 = new Account(1001, "Alex", 500.0);
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account account in accounts)
            {
                sum += account.Balance;
            }
            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account account in accounts)
            {
                account.Withdraw(10.0);
            }
            foreach (Account account in accounts)
            {
                Console.WriteLine($"Updated balance for account {account.Number}: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
