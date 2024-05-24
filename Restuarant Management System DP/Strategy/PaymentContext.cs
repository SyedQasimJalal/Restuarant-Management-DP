using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Strategy
{
    internal class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public string PayBill(decimal amount)
        {
            if (paymentStrategy == null)
            {
                return ("Payment strategy is not set.");
            }
            return paymentStrategy.Pay(amount);
        }
    }
}
