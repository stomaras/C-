using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Over time, needs change, and related account types are requested:
 * 
 * - An interest earning account that accrues interest at the end of each month.
 * - A line of credit that can have a negative balance, but when there is balance, there is an interest charge each month.
 * - A pre-paid gift card account that starts with a single deposit, and only can be paid off. It can be refilled once at the start of each month
 * 
 * We can see that all of these account types have an action that takes places at the end of each month.However, each account type does different tasks.
 * We will use polymorphism to implement this code. Create a single virtual method in the BankAccount class.
 * 
 */

namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;
            try
            {
                account = new BankAccount("Tomaras Spyros", 5000);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(ex.ToString());
                return;
            }

            // Test for a negative balance.
            try
            {
                account.MakeWithDrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            account.MakeDeposit(30, DateTime.Now, "Daily Income");
            account.MakeDeposit(400, DateTime.Now, "Sell of desk");

            Console.WriteLine(account.GetAccountHistory());
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithDrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithDrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            giftCard.MakeDeposit(27, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("Saving Account", 100000);
            savings.MakeDeposit(750, DateTime.Now, "Save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add some savings");
            savings.MakeWithDrawal(250, DateTime.Now, "Needed to pay monthly");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

        }
    }
}
