using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Factory_Method
{
    internal interface ICustomerRegistration
    {
        bool RegisterCustomer(string name, string email, string password);
    }
}
