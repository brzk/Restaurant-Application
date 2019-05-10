using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace DishCreator
{
    public class MainDishBuilder : DishBuilder
    {
        public MainDish MainDish { get; set; }

        public override void SetMainDishRank()
        {
            if (DishRanks.DishesRank.TryGetValue(eDishYypes.MainDish, out int rank))
            {
                MainDish.MainRank = rank;
            }
        }

        public override void SetSecondDishRank()
        {
            MainDish.SecondRank = 1;
        }

        public override void SetThirdDishRank()
        {
            if (DishRanks.MainDishRanks.TryGetValue(MainDish.MainDishType,out int rank))
            {
                MainDish.ThirdRank = rank;
            }            
        }

        public override void SetDishPrice()
        {
            if (DishPrices.MainDishPrices.TryGetValue(MainDish.MainDishType, out int price))
            {
                MainDish.Price = price;
            }
        }

        public override Dish GetDish()
        {
            return MainDish;
        }
    }
}
