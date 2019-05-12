using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public static class OrderSorts
    {
        private static Dictionary<eSortTyps, RankSort> Sorts = new Dictionary<eSortTyps, RankSort>()
        {
            {eSortTyps.MainRankSort, new MainRankSort() },
            {eSortTyps.MainRankSort, new SecondRankSort() },
            {eSortTyps.MainRankSort, new ThirdRankSort() }
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
