using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public static class OrderSorts
    {
        //private static RankSort RankSort;
        private static readonly Dictionary<eSortTyps, RankSort> Sorts = new Dictionary<eSortTyps, RankSort>()
        {
            {eSortTyps.MainRankSort, new MainRankSort() },
            {eSortTyps.SecondRankSort, new SecondRankSort() },
            {eSortTyps.ThirdRankSort, new ThirdRankSort() }
        };

        public static List<Dish> Sort(this List<Dish> dishes, eSortTyps sortTyps)
        {
            return Sorts[sortTyps].Sort(dishes);
        }
    }

    public enum eSortTyps
    {
        MainRankSort,
        SecondRankSort,
        ThirdRankSort
    }
}
