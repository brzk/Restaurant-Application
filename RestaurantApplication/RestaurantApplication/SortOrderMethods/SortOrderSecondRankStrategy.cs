using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public class SortOrderSecondRankStrategy : SortOrderStrategy
    {
        public override bool ToSwap(int firstDish, int secondDish)
        {
            return Dishes[firstDish].SecondRank > Dishes[secondDish].SecondRank;
        }
    }
}
