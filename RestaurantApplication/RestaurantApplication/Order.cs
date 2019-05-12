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
            SortOrderStrategy.Dishes = Dishes;

            SortOrderStrategy s = new SortOrderThirdRankStrategy();
            s.Sort();

            s = new SortOrderSecondRankStrategy();
            s.Sort();

            s = new SortOrderMainRankStrategy();
            s.Sort();

            Dishes = SortOrderStrategy.Dishes;
        }
    }
}
