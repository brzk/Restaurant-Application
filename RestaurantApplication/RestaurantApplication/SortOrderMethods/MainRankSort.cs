using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public class MainRankSort : RankSort
    {
        public override bool ToSwap(Dish firstDish, Dish secondDish)
        {
            return firstDish.MainRank > secondDish.MainRank;
        }
    }
}
