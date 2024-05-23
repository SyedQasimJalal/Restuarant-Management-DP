using Restuarant_Management_System_DP.Factory_Method;
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
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creator customerCreator;
            bool isRegistered = false;
            if (regularRadioBtn.Checked == true)
            {
                customerCreator = new ConcreteRegularCustomerCreator();
                isRegistered = customerCreator.Register(nameTxt.Text, emailTxt.Text, passTxt.Text);
                register(isRegistered);
            }
            else if(premiumRadioButton.Checked == true) {
                customerCreator = new ConcretePremiumCustomerCreator();
                isRegistered = customerCreator.Register(nameTxt.Text, emailTxt.Text, passTxt.Text);
                register(isRegistered);
            }
            else
            {
                MessageBox.Show("Please fill whether you want to be a regular or premium!!");
            }
            
        }

        private void register(bool isRegistered)
        {
            if (isRegistered)
            {
                MessageBox.Show("Registered Successfully!!");
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not registered");
            }
        }
    }
}
