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
            Appetizer appetizer = InitializeDishes.InitializeAppetizer("chicken", 2, 1, eAppetizer.ChickenNuggets);
            Assert.AreEqual(eAppetizer.ChickenNuggets, appetizer.AppetizerType);
            Assert.AreEqual(30, appetizer.Price);
        }

        [TestMethod]
        public void InitializeAppetizer2()
        {
            Appetizer appetizer = InitializeDishes.InitializeAppetizer("chicken", 2, 1, eAppetizer.ChickenSkewers);
            Assert.AreEqual(eAppetizer.ChickenSkewers, appetizer.AppetizerType);
        }

        [TestMethod]
        public void InitializeMainDish()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("chicken", 2, 1, eMainDish.ChickenBreast);
            Assert.AreEqual(eMainDish.ChickenBreast, mainDish.MainDishType);
        }

        [TestMethod]
        public void InitializeMainDish2()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("chicken", 2, 1, eMainDish.Schnitzel);
            Assert.AreEqual(eMainDish.Schnitzel, mainDish.MainDishType);
        }

        [TestMethod]
        public void InitializeMainDish3()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("chicken", 2, 1, eMainDish.Schnitzel);
            Assert.AreEqual(eMainDish.Schnitzel, mainDish.MainDishType);
        }

    }
}
