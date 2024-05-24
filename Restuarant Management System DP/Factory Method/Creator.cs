using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Factory_Method
{
    internal abstract class Creator
    {
        
        public bool Register(string name, string email, string password)
        {
            ICustomerRegistration customerRegistration = CreateCustomer();
            return customerRegistration.RegisterCustomer(name, email, password);
        }

        public abstract ICustomerRegistration CreateCustomer();
    }
}
