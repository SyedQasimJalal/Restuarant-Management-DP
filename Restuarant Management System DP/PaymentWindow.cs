using Restuarant_Management_System_DP.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_Management_System_DP
{
    public partial class PaymentWindow : Form
    {
        PaymentContext context;
        IPaymentStrategy strategy;

        public PaymentWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context = new PaymentContext();
            strategy = new CreditCardPayment("","","","");
            context.SetPaymentStrategy(strategy);
            MessageBox.Show(context.PayBill(100));
        }

        private void paypal_btn_Click(object sender, EventArgs e)
        {
            context = new PaymentContext();
            strategy = new PayPalPayment("");
            context.SetPaymentStrategy(strategy);
            MessageBox.Show(context.PayBill(100));
        }

        private void cash_Click(object sender, EventArgs e)
        {
            context = new PaymentContext();
            strategy = new CashPayment();
            context.SetPaymentStrategy(strategy);
            MessageBox.Show(context.PayBill(100));
        }
    }
}
