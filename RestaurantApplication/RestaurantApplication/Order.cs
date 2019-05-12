using RestaurantApplication.SortOrderMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class Order
    {
        public List<Dish> Dishes { get; set; }

        public Order()
        {
            Dishes = new List<Dish>();
        }

        public void SortOrder()
        {
            Dishes = Dishes.Sort(eSortTyps.ThirdRankSort);
            Dishes = Dishes.Sort(eSortTyps.SecondRankSort);
            Dishes = Dishes.Sort(eSortTyps.MainRankSort);
        }
    }
}
