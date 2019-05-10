using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class DishTypes
    {

        public enum eDishYypes
        {
            Appetizer,
            MainDish
        }

        public enum eAppetizer
        {
            ChickenNuggets,
            ChickenSkewers,
            ChickenWings
        };

        public enum eMainDish
        {
            Schnitzel,
            ChickenBreast,
            SpringChicken,
        };
    }
}
