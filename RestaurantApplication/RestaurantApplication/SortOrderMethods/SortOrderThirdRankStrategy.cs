using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public class SortOrderThirdRankStrategy : SortOrderStrategy
    {
        public override bool ToSwap(int firstDish, int secondDish)
        {
            return Dishes[firstDish].ThirdRank > Dishes[secondDish].ThirdRank;
        }
    }
}
