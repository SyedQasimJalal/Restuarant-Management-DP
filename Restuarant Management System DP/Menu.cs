using Restuarant_Management_System_DP.Abstract_Factory;
using Restuarant_Management_System_DP.Abstract_Factory.Deal_Factories;
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
    public partial class Menu : Form
    {
        IAbstractBeverageProduct beverage;
        IAbstractPizzaProduct pizza;
        IOrderAbstractFactory orderAbstractFactory;
        FormManager manager;

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dealType = null;
            if (radioButton1.Checked)
            {
                orderAbstractFactory = new ConcreteDeal1Factory();
                dealType = "Deal 1: Cheesy Heaven and Lemon & Lime";
            }
            else if(radioButton2.Checked)
            {
                orderAbstractFactory = new ConcreteDeal2Factory();
                dealType = "Deal 2: Steamy Tikka and Orange Punch";
            }
            else if (radioButton3.Checked)
            {
                orderAbstractFactory = new ConcreteDeal3Factory();
                dealType = "Deal 3: Pepperoni Madness and Orange Punch";
            }

            pizza= orderAbstractFactory.CreatePizza();
            beverage = orderAbstractFactory.CreateBeverage();

            bool isPrepared = pizza.Prepare();
            bool isPoured = beverage.Pour();


            if(isPrepared && isPoured)
            {
                MessageBox.Show("Order placed successfully: "+dealType);
                manager= new FormManager();
                manager.OpenNewForm(this, new PaymentWindow());
            }
        }


    }
}
