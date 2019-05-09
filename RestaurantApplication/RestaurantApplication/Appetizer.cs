using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace RestaurantApplication
{
    public class Appetizer : Dish 
    {
        public eAppetizer AppetizerType { get; set; }
        public Appetizer(string name, int price, int quantity, int dinerSerialNumber, eAppetizer appetizerType) : base(name, price, quantity, dinerSerialNumber) { }       
    }
}
