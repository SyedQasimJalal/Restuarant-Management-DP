using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Strategy
{
    internal class PayPalPayment : IPaymentStrategy
    {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public string Pay(decimal amount)
        {
            // Simulate PayPal payment processing
            return($"Processing PayPal payment of {amount:C} for email {email}.");
        }

    }
}
