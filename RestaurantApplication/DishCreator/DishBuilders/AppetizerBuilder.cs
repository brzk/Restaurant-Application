using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreator
{
    public class AppetizerBuilder : DishBuilder
    {
        public Appetizer Appetizer { get; set; }
       
        public override void SetMainDishRank()
        {
            if (DishRanks.AppetizerRanks.TryGetValue(Appetizer.AppetizerType, out int rank))
            {
                Appetizer.MainRank = rank;
            }
        }

        public override void SetSecondDishRank()
        {
            throw new NotImplementedException();
        }

        public override void SetThirdDishRank()
        {
            throw new NotImplementedException();
        }
        public override void SetDishPrice()
        {
            if (DishPrices.AppetizerPrices.TryGetValue(Appetizer.AppetizerType, out int price))
            {
                Appetizer.Price = price;
            }
        }

        public override Dish GetDish()
        {
            return Appetizer;
        }
    }
}
