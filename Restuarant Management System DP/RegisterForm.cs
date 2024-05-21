using Restuarant_Management_System_DP.Controllers;
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

        private RegistrationController registrationController;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrationController = new RegistrationController();
            bool isRegistered= registrationController.RegisterUser(nameTxt.Text, emailTxt.Text, passTxt.Text, confirmPassTxt.Text);
            if (isRegistered)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("incorrect password");
            }
        }
    }
}
