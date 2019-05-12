using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public abstract class RankSort
    {
        public abstract bool ToSwap(Dish firstDish, Dish secondDish);

        public List<Dish> Sort(List<Dish> dishes)
        {
            for (int i = 0; i < dishes.Count; i++)
            {
                for (int j = 1; j < dishes.Count - i; j++)
                {
                    if (ToSwap(dishes[j - 1], dishes[j]))
                    {
                        Swap(dishes,j - 1, j);
                    }
                }
            }

            return dishes;
        }

        private void Swap(List<Dish> dishes, int firstDish, int secondDish)
        {
            Dish tempDish = dishes[firstDish];
            dishes[firstDish] = dishes[secondDish];
            dishes[secondDish] = tempDish;
        }
    }
}
