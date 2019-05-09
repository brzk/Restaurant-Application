using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace DishCreator
{
    public static class DishRanks
    {
        public static Dictionary<eAppetizer, int> AppetizerRanks = new Dictionary<eAppetizer, int>()
        {
            { eAppetizer.ChickenNuggets, 1 },
            { eAppetizer.ChickenSkewers, 2 },
            { eAppetizer.ChickenWings, 3 }
        };

        public static Dictionary<eMainDish, int> MainDishRanks = new Dictionary<eMainDish, int>()
        {
            { eMainDish.ChickenBreast, 1 },
            { eMainDish.Schnitzel, 2 },
            { eMainDish.SpringChicken, 3 }
        };
    }
}
