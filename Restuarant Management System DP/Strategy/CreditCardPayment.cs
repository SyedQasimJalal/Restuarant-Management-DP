using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Strategy
{
    internal class CreditCardPayment:IPaymentStrategy
    {
        private string cardNumber;
        private string cardHolderName;
        private string expirationDate;
        private string cvv;

        public CreditCardPayment(string cardNumber, string cardHolderName, string expirationDate, string cvv)
        {
            this.cardNumber = cardNumber;
            this.cardHolderName = cardHolderName;
            this.expirationDate = expirationDate;
            this.cvv = cvv;
        }

        public string Pay(decimal amount)
        {
            // Simulate credit card payment processing
            return($"Processing credit card payment of {amount:C} for card holder {cardHolderName}.");
        }
    }
}
