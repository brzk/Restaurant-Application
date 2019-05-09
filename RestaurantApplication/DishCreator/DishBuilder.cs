using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreator
{
    public abstract class DishBuilder
    {
        public abstract void SetMainDishRank();
        public abstract void SetSecondDishRank();
        public abstract void SetThirdDishRank();
    }
}
