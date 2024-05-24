using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Strategy
{
    internal class CashPayment : IPaymentStrategy
    {
        public string Pay(decimal amount)
        {
            // Simulate cash payment processing
            return ($"Processing cash payment of {amount:C}.");
        }
    }
}