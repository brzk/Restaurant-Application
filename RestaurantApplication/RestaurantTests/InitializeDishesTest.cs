using System;
using DishCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantApplication;
using static RestaurantApplication.DishTypes;

namespace RestaurantTests
{
    [TestClass]
    public class InitializeDishesTest
    {
        [TestMethod]
        public void InitializeAppetizer()
        {
            Appetizer appetizer = InitializeDishes.InitializeAppetizer("chicken", 2, 1, eAppetizer.ChickenNuggets);
            Assert.AreEqual(eAppetizer.ChickenNuggets, appetizer.AppetizerType);
        }
    }
}
