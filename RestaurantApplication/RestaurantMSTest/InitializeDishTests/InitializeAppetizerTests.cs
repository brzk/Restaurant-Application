using DishCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantApplication;
using System;
using System.Collections.Generic;
using System.Text;
using static RestaurantApplication.DishTypes;

namespace RestaurantMSTest.InitializeDishTests
{
    [TestClass]
    public class InitializeAppetizerTests
    {
        [TestMethod]
        public void InitializeAppetizer_ChickenNuggets()
        {
            string name = "Chicken Nuggets";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eAppetizer appetizerType = eAppetizer.ChickenNuggets;
            Appetizer appetizer = InitializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);

            Assert.AreEqual(appetizerType, appetizer.AppetizerType);
            Assert.AreEqual(dinerSerialNumber, appetizer.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishTypes.Appetizer], appetizer.MainRank);
            Assert.AreEqual(name, appetizer.Name);
            Assert.AreEqual(DishPrices.AppetizerPrices[appetizerType], appetizer.Price);
            Assert.AreEqual(quantity, appetizer.Quantity);
            Assert.AreEqual(1, appetizer.SecondRank);
            Assert.AreEqual(DishRanks.AppetizerRanks[appetizerType], appetizer.ThirdRank);
        }

        [TestMethod]
        public void InitializeAppetizer_ChickenSkewers()
        {
            string name = "Chicken Skewers";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eAppetizer appetizerType = eAppetizer.ChickenSkewers;
            Appetizer appetizer = InitializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);

            Assert.AreEqual(appetizerType, appetizer.AppetizerType);
            Assert.AreEqual(dinerSerialNumber, appetizer.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishTypes.Appetizer], appetizer.MainRank);
            Assert.AreEqual(name, appetizer.Name);
            Assert.AreEqual(DishPrices.AppetizerPrices[appetizerType], appetizer.Price);
            Assert.AreEqual(quantity, appetizer.Quantity);
            Assert.AreEqual(1, appetizer.SecondRank);
            Assert.AreEqual(DishRanks.AppetizerRanks[appetizerType], appetizer.ThirdRank);
        }

        [TestMethod]
        public void InitializeAppetizer_ChickenWings()
        {
            string name = "Chicken Wings";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eAppetizer appetizerType = eAppetizer.ChickenWings;
            Appetizer appetizer = InitializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);

            Assert.AreEqual(appetizerType, appetizer.AppetizerType);
            Assert.AreEqual(dinerSerialNumber, appetizer.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishTypes.Appetizer], appetizer.MainRank);
            Assert.AreEqual(name, appetizer.Name);
            Assert.AreEqual(DishPrices.AppetizerPrices[appetizerType], appetizer.Price);
            Assert.AreEqual(quantity, appetizer.Quantity);
            Assert.AreEqual(1, appetizer.SecondRank);
            Assert.AreEqual(DishRanks.AppetizerRanks[appetizerType], appetizer.ThirdRank);
        }        
    }
}
