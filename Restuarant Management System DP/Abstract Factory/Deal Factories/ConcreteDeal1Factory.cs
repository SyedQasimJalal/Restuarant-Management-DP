using Restuarant_Management_System_DP.Abstract_Factory.Concrete_Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Abstract_Factory
{
    internal class ConcreteDeal1Factory : IOrderAbstractFactory
    {
        public IAbstractBeverageProduct CreateBeverage()
        {
            return new ConcreteLemonLime();
        }

        public IAbstractPizzaProduct CreatePizza()
        {
            return new ConcreteCheesePizza();
        }

    }
}
