using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace DishCreator
{
    public static class DishPrices
    {
        public static Dictionary<eAppetizer, int> AppetizerPrices = new Dictionary<eAppetizer, int>()
      {
          { eAppetizer.ChickenNuggets, 30 },
            { eAppetizer.ChickenSkewers, 35 },
            { eAppetizer.ChickenWings, 31 }
      };

        public static Dictionary<eMainDish, int> MainDishRanks = new Dictionary<eMainDish, int>()
        {
            { eMainDish.ChickenBreast, 42 },
            { eMainDish.Schnitzel, 55 },
            { eMainDish.SpringChicken, 60 }
        };
    }
}
