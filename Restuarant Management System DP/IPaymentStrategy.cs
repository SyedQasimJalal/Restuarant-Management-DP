using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
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

        public void Pay(decimal amount)
        {
            // Simulate credit card payment processing
            Console.WriteLine($"Processing credit card payment of {amount:C} for card holder {cardHolderName}.");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public void Pay(decimal amount)
        {
            // Simulate PayPal payment processing
            Console.WriteLine($"Processing PayPal payment of {amount:C} for email {email}.");
        }
    }

    public class CashPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            // Simulate cash payment processing
            Console.WriteLine($"Processing cash payment of {amount:C}.");
        }
    }

    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public void PayBill(decimal amount)
        {
            if (paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy is not set.");
            }
            paymentStrategy.Pay(amount);
        }
    }
}
