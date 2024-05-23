using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP
{
    public sealed class Pizza_Builder
    {
        private readonly Pizza _pizza;


        public Pizza_Builder()
        {
            _pizza = new Pizza(false, false, false, false, false, false, false);
        }


        public Pizza_Builder AddCheese() 
        {
            _pizza.HasCheese = true;
            return this;
        
        }

        public Pizza_Builder AddPepperoni()
        {
            _pizza.HasPepperoni = true;
            return this;

        }

        public Pizza_Builder AddTomatoSauce()
        {
            _pizza.HasTomatoSauce = true;
            return this;

        }

        public Pizza_Builder AddChicken()
        {
            _pizza.HasChicken = true;
            return this;

        }

        public Pizza_Builder AddBeef()
        {
            _pizza.HasBeef = true;
            return this;

        }

        public Pizza_Builder AddBellPepper()
        {
            _pizza.HasBellPepper = true;
            return this;

        }

        public Pizza_Builder AddOtherSauces()
        {
            _pizza.HasotherSauces = true;
            return this;

        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
