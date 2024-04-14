using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Transaction
    {
        public decimal Amount { get; }//deposito - retiro
        public DateTime Date { get; }
        public string Note {  get; }

        public Transaction(decimal xAmount, DateTime xDate, string xNote)
        {
            this.Amount = xAmount;
            this.Date = xDate;
            this.Note = xNote;  

        }
    }
}
