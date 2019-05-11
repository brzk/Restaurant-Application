using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace DishCreator
{
    public class AppetizerBuilder : DishBuilder
    {
        public Appetizer Appetizer { get; set; }
       
        public override void SetMainDishRank()
        {
            if (DishRanks.DishesRank.TryGetValue(eDishYypes.Appetizer, out int rank))
            {
                Appetizer.MainRank = rank;
            }
        }

        public override void SetSecondDishRank()
        {
            Appetizer.SecondRank = 1;            
        }

        public override void SetThirdDishRank()
        {
            if (DishRanks.AppetizerRanks.TryGetValue(Appetizer.AppetizerType, out int rank))
            {
                Appetizer.ThirdRank = rank;
            }
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
