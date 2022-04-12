using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    /*
     * A pre-paid gift card account that starts with a single deposit, and only can be paid off.It can be refilled once at the start 
     * of each month.
     * - Can be refilled with a specified amount once each month, on the last day of the month.
     */
    public class GiftCardAccount : BankAccount
    {
        // this field is immutable
        // indicates that assigment to the field can only occur as part of the declaration or in a constructor 
        // in the same class. A readonly type can not be assigned after the constructor exits.
        /*
         * The readonly keyword is # from the const keyword. A const field can only be initialized at the declaration of the field.
         * A readonly field can be assigned multiple times in the field declaration and in any constructor.Therefore readonly fields can have 
         * different values depending on the constructor used.
         * 
         */
        private readonly decimal _monthlyDeposit = 0m;

        // The Constructor provides a default value for the monthlyDeposit value so callers can omit a 0 for no monthly deposit.
        // base() syntax to indicate a call to a base class constructor. Some classes defines multiples constructors, and this syntax 
        // enables you to pick which base class constructor you call.
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if(_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }



    }
}
