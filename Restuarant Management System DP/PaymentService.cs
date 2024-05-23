using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP
{
    public class PaymentService
    {
        private int cost;
        private Boolean includeDelivery;


        public void processOrder() 
        {
        
        
        }
        private int getTotal()
        {
            return includeDelivery ? cost + 10 : cost;
        
        }


    }
}
