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
    public class SqlConnectionMSTest
    {
        [TestMethod]
        public void AddMainDishToDB()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("chicken", 2, 2, 1, eMainDish.ChickenBreast);
            mainDish.Price = 30;
            Broker broker = new Broker();
            broker.Insert(mainDish);
            
            Assert.AreEqual(eAppetizer.ChickenNuggets, eAppetizer.ChickenNuggets);
        }

        [TestMethod]
        public void UpdateMainDishToDB()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("ChickenBreast", 2, 2, 1, eMainDish.ChickenBreast);
            mainDish.Price = 42;
            Broker broker = new Broker();
            broker.Update(mainDish);

            Assert.AreEqual(eAppetizer.ChickenNuggets, eAppetizer.ChickenNuggets);
        }

        [TestMethod]
        public void SelectMainDishToDB()
        {
            MainDish mainDish = InitializeDishes.InitializeMainDish("ChickenBreast", 2, 2, 1, eMainDish.ChickenBreast);
            mainDish.Price = 70;
            Broker broker = new Broker();
           string name =  broker.Select(mainDish);

            Assert.AreEqual("ChickenBreast", name);
        }
    }
}
