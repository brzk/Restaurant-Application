using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class Appetizer : Dish 
    {
        public Appetizer(string name, int price, int quantity, int dinerSerialNumber) : base(name, price, quantity, dinerSerialNumber) { }       
    }
}
