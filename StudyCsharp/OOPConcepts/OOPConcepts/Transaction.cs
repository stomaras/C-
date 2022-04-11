using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public String Notes { get; }

        


        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }

        /*
         * The current balance can be found by summing the values of all 
         * transactions.
         * 
         */


        /*
         * Next implement the MakeDeposit and MakeWithdrawal methods.
         * These methods will enforce the final two rules: that the 
         * initial balance must be positive, and that any withdrawal 
         * must not create a negative balance.
         * This introduces the concept of exceptions. The standard way of 
         * indicating that a method cannot complete its work successfully 
         * is to throw an exception.The type of exception and the message associated 
         * with it describe the error.
         */

        





    }
}
