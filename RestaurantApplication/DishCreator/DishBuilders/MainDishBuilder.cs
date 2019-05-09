using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DishCreator
{
    public class MainDishBuilder : DishBuilder
    {
        public MainDish MainDish { get; set; }        

        public override void SetMainDishRank()
        {
            throw new NotImplementedException();
        }

        public override void SetSecondDishRank()
        {
            throw new NotImplementedException();
        }

        public override void SetThirdDishRank()
        {
            throw new NotImplementedException();
        }

        public override void SetDishPrice()
        {
            throw new NotImplementedException();
        }

        public override Dish GetDish()
        {
            return MainDish;
        }
    }
}
