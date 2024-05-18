using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Proxy
{
    internal class AuthenticationSubject : IAuthentication
    {
        public bool Authenticate(string username, string password)
        {

            return false;
        }
    }
}
