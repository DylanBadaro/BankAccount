using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get
            {
                decimal xBalance = 0;
                foreach(var item in allTransactions)
                {
                    xBalance = xBalance + item.Amount;
                }
                return xBalance;
            }
        }

        private static int accountNumber =807;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string xName, decimal xInitialDeposit, DateTime xDate) 
        {
            this.Owner = xName;
            this.Number = accountNumber.ToString();
            accountNumber++;
            // Balance
            MakeDeposit(xInitialDeposit, xDate, "Initial Account Bank");
        }

        //Deposits
        public void MakeDeposit(decimal xAmount, DateTime xDate, string xNote)
        {
            if(xAmount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(xAmount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(xAmount, xDate, xNote);
            allTransactions.Add(deposit);
        }
        //Withdrawals
        public void MakeWithDrawall(decimal xAmount, DateTime xDate, string xNote)
        {
            if(xAmount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(xAmount), "Amount with drawall must be positive");
            }
            if((Balance - xAmount) < 0)
            {
                throw new InvalidOperationException("You not sufficiente found for this transaction");
            }
            var deposit = new Transaction(-xAmount, xDate, xNote);
            allTransactions.Add(deposit);
        }

        public string getAccountHistory() 
        {
            var xReport = new StringBuilder();
            xReport.AppendLine("Date \t\t\t Amount \t Note");
            foreach(var item in allTransactions) 
            { 
                xReport.AppendLine($"{item.Date.ToShortDateString()} \t\t{item.Amount} \t {item.Note}");
            }
            return xReport.ToString();
        }
    }
}
