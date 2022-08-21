using System;
using System.Text;

namespace BankAccount
{
    public class Account
    {
        private static int accNumber { get; set;  }
        public string owner { get; set; }
        public decimal balance
        {
            get
            {
                decimal bal = 0;
                foreach(Transaction t in allTransactions)
                {
                    bal += t.transAmount;
                }
                return bal;
            }
        }
        //public List<Transaction> allTransactions = new List<Transaction>(); // valid statement
        public List<Transaction> allTransactions = new(); // simplified

        public Account(string name, decimal initDeposit)
        {
            accNumber++;
            owner = name;
            makeDeposit(initDeposit, DateTime.Now, "Initial deposit");
        }

        public void makeDeposit(decimal amount, DateTime dt, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount cannot be zero or negative");
            }

            Transaction t = new(amount,DateTime.Now,note);
            allTransactions.Add(t);

        }

        public void withDrawal(decimal amount, DateTime dt, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount cannot be zero or negative");
            } else
            {
                if (balance - amount < 0)
                {
                    throw new InvalidOperationException("Insufficient balance");
                }
            }

            Transaction t = new(-amount, DateTime.Now, note);
            allTransactions.Add(t);
        }

        public string getTransactionDetails()
        {
            var report = new StringBuilder();

            report.AppendLine("Transaction Date\t\tAmount\t\tNote");
            foreach(var item in allTransactions)
            {
                report.AppendLine($"{item.transDate.ToShortDateString()}\t\t\t{item.transAmount}\t\t{item.transNotes}");
            }

            return report.ToString();
        }

    }
}
