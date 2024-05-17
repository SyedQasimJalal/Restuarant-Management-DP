using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP
{
    class Payment_Method
    {

        interface Pay
        {

            void Payment();

        }
        public class CardPayment : Pay 
        {

            public void Payment() { }
        
        }
        public class Cash : Pay 
        {

            public void Payment() { }


        }
        public class Transaction 
        {

            CardPayment card;
            Cash cash;

            public void ExecuteTansaction(CardPayment card , Cash cash) 
            {
             
                 void Request ()
                    Singleton method 
            
            
            }
        
         
        }


    }
}

