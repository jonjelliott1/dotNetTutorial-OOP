using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var account = new BankAccount("Andrea-Elliott", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with account balance {account.Balance}");

            account.MakeWithdrawel(100, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);


           

            account.MakeWithdrawel(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());

            ////Test that the initial balance must be positive
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);

            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());

            //}


        }
    }
}
