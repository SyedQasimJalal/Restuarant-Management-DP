using Restaurant_Management_System_DP.Singleton;
using Restuarant_Management_System_DP.Abstract_Factory.Concrete_Beverages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
