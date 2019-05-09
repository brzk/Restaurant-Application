using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class MainDish : Dish
    {
        public MainDish(string name, int price, int quantity, int dinerSerialNumber) : base(name, price, quantity, dinerSerialNumber) { }       
    }
}
