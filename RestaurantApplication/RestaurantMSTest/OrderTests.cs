using DishCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace RestaurantMSTest
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderTests_SortOrder()
        {
            Order order = new Order();

            string name = "Spring Chicken";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eMainDish mainDishType = eMainDish.SpringChicken;
            MainDish mainDish2 = InitializeDishes.InitializeMainDish(name, quantity, dinerSerialNumber, mainDishType);
            order.Dishes.Add(mainDish2);


            name = "Chicken Nuggets";
            quantity = 2;
            dinerSerialNumber = 1;
            eAppetizer appetizerType = eAppetizer.ChickenNuggets;
            Appetizer appetizer = InitializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);

            order.Dishes.Add(appetizer);

            name = "Schnitzel";
            quantity = 2;
            dinerSerialNumber = 1;
             mainDishType = eMainDish.Schnitzel;
            MainDish mainDish = InitializeDishes.InitializeMainDish(name, quantity, dinerSerialNumber, mainDishType);

            order.Dishes.Add(mainDish);

            name = "Chicken Skewers";
            quantity = 2;
            dinerSerialNumber = 1;
            appetizerType = eAppetizer.ChickenSkewers;
            Appetizer appetizer2 = InitializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);
            
            order.Dishes.Add(appetizer2);

            order.SortOrder();

            Assert.AreEqual(order.Dishes[0].Name, appetizer.Name);
            Assert.AreEqual(order.Dishes[1].Name, appetizer2.Name);
            Assert.AreEqual(order.Dishes[2].Name, mainDish.Name);
            Assert.AreEqual(order.Dishes[3].Name, mainDish2.Name);
        }
    }
}
