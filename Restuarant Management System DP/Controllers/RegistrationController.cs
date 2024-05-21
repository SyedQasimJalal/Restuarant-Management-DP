using Restuarant_Management_System_DP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Controllers
{
    class RegistrationController
    {

        private Customer customer;

        public bool RegisterUser(string name, string email, string password, string confirmPassword)
        {
            customer = new Customer(name, email, password, confirmPassword);
            if (customer.IsPasswordMatching())
            {
                //store the credentials into database
                return true;
            }
            return false;
        }
    }
}
