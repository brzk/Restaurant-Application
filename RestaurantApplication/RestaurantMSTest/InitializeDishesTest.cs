using DishCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantApplication;
using static RestaurantApplication.DishTypes;

namespace RestaurantMSTest
{
    [TestClass]
    public class InitializeDishesTest
    {
        [TestMethod]
        public void InitializeAppetizer()
        {
            Appetizer appetizer = InitializeDishes.InitializeAppetizer("chicken", 2, 2, 1, eAppetizer.ChickenNuggets);
            Assert.AreEqual(eAppetizer.ChickenNuggets, appetizer.AppetizerType);
        }

        [TestMethod]
        public void InitializeMainDish()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("chicken", 2, 2, 1, eMainDish.ChickenBreast);
            Assert.AreEqual(eMainDish.ChickenBreast, mainDish.MainDishType);
        }
    }
}
