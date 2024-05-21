using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Model
{
    class Customer
    {
        private string name, email, password, confirmPassword;

        public Customer(string name, string email, string password, string confirmPassword)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.confirmPassword = confirmPassword;
        }

        public bool IsPasswordMatching()
        {
            if (password.Equals(confirmPassword))
            {
                return true;
            }
            return false;
        }

        public void Store()
        {

        }
    }
}
