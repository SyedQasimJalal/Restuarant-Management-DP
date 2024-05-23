using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Proxy
{
    internal class AuthenticationProxy : IAuthentication
    {
        private IAuthentication _realAuthentication;

        public bool Authenticate(string username, string password)
        {
            if (_realAuthentication == null)
            {
                _realAuthentication = new AuthenticationSubject();
            }
            return _realAuthentication.Authenticate(username, password);
        }
    }
}
