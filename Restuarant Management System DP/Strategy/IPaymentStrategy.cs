using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP
{
    public interface IPaymentStrategy
    {
        string Pay(decimal amount);
    }

}
