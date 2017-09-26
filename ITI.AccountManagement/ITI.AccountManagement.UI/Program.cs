using System;
using ITI.AccountManagement;

namespace ITI.AccountManagement.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("845236658", "0123", 5000);
            int balance = account.GetBalance("0123");
            Console.WriteLine("Balance: {0}", balance);

            bool success = account.Debit("0123", 2000);
            balance = account.GetBalance("0123");
            Console.WriteLine("Balance: {0}", balance);

            account.Credit(1000);
            balance = account.GetBalance("0123");
            Console.WriteLine("Balance: {0}", balance);

            success = account.ChangePassword("0123", "4321");
            balance = account.GetBalance("0123");
            Console.WriteLine("Balance: {0}", balance);
            balance = account.GetBalance("4321");
            Console.WriteLine("Balance: {0}", balance);
        }
    }
}
