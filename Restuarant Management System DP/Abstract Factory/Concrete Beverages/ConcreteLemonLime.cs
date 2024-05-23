using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Abstract_Factory.Concrete_Beverages
{
    internal class ConcreteLemonLime : IAbstractBeverageProduct
    {
        public bool Pour()
        {
            return true;
        }
    }
}
