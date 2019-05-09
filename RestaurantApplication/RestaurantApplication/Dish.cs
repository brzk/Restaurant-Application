using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public abstract class Dish
    {
        protected int MainRank { get; set; }
        protected int SecondRank { get; set; }
        protected int ThirdRank { get; set; }
        protected int Price { get; set; }
        protected int Quantity { get; set; }
        
        protected readonly string Name;
        protected readonly int DinerSerialNumber;

        public Dish(string name, int price , int quantity, int dinerSerialNumber)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            DinerSerialNumber = dinerSerialNumber;            
        }
    }
}
