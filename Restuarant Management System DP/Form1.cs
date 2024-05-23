using Restuarant_Management_System_DP.Proxy;
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
    
    public partial class Form1 : Form
    {

        RegisterForm registerForm;
        FormManager formManager;
        private IAuthentication _authentication;

        public Form1()
        {
            InitializeComponent();
            registerForm= new RegisterForm();
            formManager= new FormManager();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            bool isAuthenticated = _authentication.Authenticate(username, password);

            if (isAuthenticated)
            {
                formManager.OpenNewForm(this, registerForm);
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

            Application.Run(new Menu());
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formManager.OpenNewForm(this, registerForm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
