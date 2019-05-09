using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreator.DishBuilders
{
    public static class DishBuilders
    {
        public static AppetizerBuilder AppetizerBuilder = new AppetizerBuilder();
        public static MainDishBuilder MainDishBuilder = new MainDishBuilder();
    }
}
