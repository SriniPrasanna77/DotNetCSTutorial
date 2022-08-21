using System;
namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Account acc = new("Srinivasa",10000);

            acc.makeDeposit(700, DateTime.Now, "MacBook");
            //Console.WriteLine(acc.balance);

            
            //try
            //{
            //    acc.withDrawal(-100, DateTime.Now, "stealing");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            

            acc.withDrawal(100, DateTime.Now, "Airticket");
            //Console.WriteLine(acc.balance);

            Console.WriteLine(acc.getTransactionDetails());
        }
    }
}

