using System;
namespace BankAccount
{
    public class Transaction
    {
        public decimal transAmount;
        public DateTime transDate;
        public string transNotes;

        public Transaction(decimal amount, DateTime dt, string note)
        {
            transAmount = amount;
            transDate = dt;
            transNotes = note;
        }
    }
}

