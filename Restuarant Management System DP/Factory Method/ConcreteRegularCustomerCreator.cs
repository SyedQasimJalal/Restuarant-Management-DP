﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Factory_Method
{
    internal class ConcreteRegularCustomerCreator : Creator
    {
        public override ICustomerRegistration CreateCustomer()
        {
            return new ConcreteRegularCustomer();
        }
    }
}
