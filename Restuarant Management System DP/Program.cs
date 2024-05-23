using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restuarant_Management_System_DP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            PaymentContext context = new PaymentContext();

            // Example: Paying with a credit card
            IPaymentStrategy creditCardPayment = new CreditCardPayment("1234-5678-9012-3456", "John Doe", "12/25", "123");
            context.SetPaymentStrategy(creditCardPayment);
            context.PayBill(100.00m);

            // Example: Paying with PayPal
            IPaymentStrategy paypalPayment = new PayPalPayment("john.doe@example.com");
            context.SetPaymentStrategy(paypalPayment);
            context.PayBill(200.00m);

            // Example: Paying with cash
            IPaymentStrategy cashPayment = new CashPayment();
            context.SetPaymentStrategy(cashPayment);
            context.PayBill(50.00m);
        }
    }
}
