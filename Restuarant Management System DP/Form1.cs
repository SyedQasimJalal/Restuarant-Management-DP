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

        Menu menu;
        FormManager formManager;
        private IAuthentication _authentication;

        public Form1()
        {
            InitializeComponent();
            menu= new Menu();
            formManager= new FormManager();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            _authentication= new AuthenticationProxy();
            bool isAuthenticated = _authentication.Authenticate(username, password);

            if (isAuthenticated)
            {
                formManager.OpenNewForm(this, menu);
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

            //Application.Run(new Menu());
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formManager.OpenNewForm(this, menu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
