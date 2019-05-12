using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public class SortOrderMainRankStrategy : SortOrderStrategy
    {
        public override bool ToSwap(int firstDish, int secondDish)
        {
            return Dishes[firstDish].MainRank > Dishes[secondDish].MainRank;            
        }
    }
}
