using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace DishCreator
{
    public static class InitializeDishes
    {
        public static Appetizer InitializeAppetizer(string name, int quantity, int dinerSerialNumber, eAppetizer appetizerType)
        {
            DishBuilders.DishBuilders.AppetizerBuilder.Appetizer = new Appetizer(name, quantity, dinerSerialNumber, appetizerType);
            DishBuilders.Director.SetDishRanks(DishBuilders.DishBuilders.AppetizerBuilder);

            return DishBuilders.DishBuilders.AppetizerBuilder.Appetizer;
        }

        public static MainDish InitializeMainDish(string name, int quantity, int dinerSerialNumber, eMainDish mainDishType)
        {
            DishBuilders.DishBuilders.MainDishBuilder.MainDish = new MainDish(name, quantity, dinerSerialNumber, mainDishType);
            DishBuilders.Director.SetDishRanks(DishBuilders.DishBuilders.MainDishBuilder);

            return DishBuilders.DishBuilders.MainDishBuilder.MainDish;
        }
    }
}
