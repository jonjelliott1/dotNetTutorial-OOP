using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount("Jonathan-Elliott", 50000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with account balance {account.Balance}");


            account = new BankAccount("Andrea-Elliott", 1234);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with account balance {account.Balance}");
        }
    }
}
