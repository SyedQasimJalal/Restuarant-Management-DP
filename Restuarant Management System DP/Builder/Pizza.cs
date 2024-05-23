using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP
{
    public class Pizza
    {
        
        public Pizza(bool hasCheese, bool hasPepperoni, bool hasTomatoSauce, bool hasBellPepper, bool hasBeef, bool hasChicken, bool hasOtherSauces ) {

            HasCheese = hasCheese;
            HasPepperoni = hasPepperoni;
            HasTomatoSauce = hasTomatoSauce;
            HasBellPepper = hasBellPepper;
            HasotherSauces = hasOtherSauces;
            HasChicken = hasChicken;
            HasBeef = hasBeef;
        }
        public bool HasCheese { get; set; }
        public bool HasPepperoni { get; set; }
        public bool HasBellPepper { get; set; }
        public bool HasBeef { get; set; }
        public bool HasChicken { get; set; }
        public bool HasotherSauces { get; set; }
        public bool HasTomatoSauce { get; set; }
        
    }
}
