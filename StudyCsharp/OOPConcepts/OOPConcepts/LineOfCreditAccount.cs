using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    /*
     * A Line of credit that can have a negative balance, but when there is a balance, there is an interest charge each month.
     * - Can have a negative balance, but not be greater in absolute value than the credit limit.
     * - Will incur an interest charge each month where the end of month balance is not 0.
     * - Will incur a fee on each withdrawal that goes over the credit limit.
     */
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if(Balance < 0)
            {
                //Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithDrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }
    }
}
