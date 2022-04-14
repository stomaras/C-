using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class CreditCard
    {
        private static int CreditCardID { get; set; }
        public string NameCard { get; set; }

        public string CardNumber { get; }
        public DateTime ExpirationDate { get; }

        public bool IsActive { get; }

        public CreditCard(string NameCard, string CardNumber, bool IsActive, DateTime ExpirationDate)
        {
            this.NameCard = NameCard;
            this.CardNumber = CardNumber;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            GetCreditCardID();
        }

        private void GetCreditCardID()
        {
            CreditCardID++;
        }

        public override string ToString()
        {
            return $"Credit Card with name: {this.NameCard}, with card number: {this.CardNumber} with active status: {this.IsActive} with expiration date: {this.ExpirationDate}";
        }

    }
}
