﻿using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace RestaurantApplication
{
    public class MainDish : Dish
    {
        public eMainDish MainDishType { get; set; }
        public MainDish(string name, int quantity, int dinerSerialNumber, eMainDish mainDishType) : base(name, quantity, dinerSerialNumber)
        {
            MainDishType = mainDishType;
        }
    }
}
