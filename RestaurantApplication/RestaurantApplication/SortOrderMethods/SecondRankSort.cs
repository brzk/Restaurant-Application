using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public class SecondRankSort : RankSort
    {
        public override bool ToSwap(Dish firstDish, Dish secondDish)
        {
            return firstDish.SecondRank > secondDish.SecondRank;
        }
    }
}
