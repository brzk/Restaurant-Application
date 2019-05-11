using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreator.DishBuilders
{
    public static class Director
    {
        public static void SetDishRanks(DishBuilder dishBuilder)
        {
            dishBuilder.SetMainDishRank();
            dishBuilder.SetSecondDishRank();
            dishBuilder.SetThirdDishRank();
            dishBuilder.SetDishPrice();
        }
    }
}
