using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class BankAccount
    {
        /*
         * It's private, which means it can only be accessed by code inside the BankAccount class.
         * it is also static, which means it is shared by all of the BankAccount objects.
         * The value of a non-static variable is unique to each instance of the BankAccount object.
         * 
         * The namespace declaration provides a way to logically organize your code
         * 
         * The bank account support this behavior:
         * 
         * 1.It has a 10-digit number that uniquely identifies the bank account.
         * 2.It has a string that stores the name or names of the owners.
         * 3.The balance can be retrieved.
         * 4.It accepts deposits
         * 5.It accepts withdrawals
         * 6.The initial balance must be positive
         * 7.Withdrawals cannot result in a negative balance.
         * 
         */
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }

        private List<Transaction> allTransactions = new List<Transaction>();
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        /*
         * Open a new Account
         * 
         * Did you notice that the account number is blank?The account number should 
         * be assigned when the object is constructed. But it should not be the responsibility 
         * of the caller to create it. The BankAccount class code should know how to assign 
         * new account numbers.
         * The first Feature to implement is to open a bank account. When a customer
         * opens an account, they must supply an initial balance, and information about the owner
         * or owners of that account.
         * Constructor is used to initialize objects of that class type.
         * 
         * 
         * 
         */
        

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            
            // with this way each time a new Bank Acount is created 
            // a unique number identifier generated for this Account 
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            // DateTime.Now is a property that returns the current date and time
            
        }

        
        
    }
}
