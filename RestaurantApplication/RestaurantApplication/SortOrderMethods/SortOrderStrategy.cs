using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication.SortOrderMethods
{
    public abstract class SortOrderStrategy
    {
        public static List<Dish> Dishes { get; set; }

        public abstract bool ToSwap(int firstDish, int secondDish);
        
        public  void Sort()
        {
            for (int i = 0; i < Dishes.Count; i++)
            {
                for (int j = 1; j < Dishes.Count - i; j++)
                {
                    if (ToSwap(j-1,j))
                    {
                        Swap(j, j - 1);
                    }
                }
            }
        }

        private void Swap(int firstDish,int secondDish)
        {
            Dish tempDish = Dishes[firstDish];
            Dishes[firstDish] = Dishes[secondDish];
            Dishes[secondDish] = tempDish;
        }        
    }
}
