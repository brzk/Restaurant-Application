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
    public class InitializeMainDishTests
    {
        [TestMethod]
        public void InitializeMainDish_ChickenBreast()
        {
            string name = "Chicken Breast";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eMainDish mainDishType = eMainDish.ChickenBreast;
            MainDish mainDish = InitializeDishes.InitializeMainDish(name, quantity, dinerSerialNumber, mainDishType);

            Assert.AreEqual(mainDishType, mainDish.MainDishType);
            Assert.AreEqual(dinerSerialNumber, mainDish.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishTypes.MainDish], mainDish.MainRank);
            Assert.AreEqual(name, mainDish.Name);
            Assert.AreEqual(DishPrices.MainDishPrices[mainDishType], mainDish.Price);
            Assert.AreEqual(quantity, mainDish.Quantity);
            Assert.AreEqual(1, mainDish.SecondRank);
            Assert.AreEqual(DishRanks.MainDishRanks[mainDishType], mainDish.ThirdRank);
        }

        [TestMethod]
        public void InitializeMainDish_Schnitzel()
        {
            string name = "Schnitzel";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eMainDish mainDishType = eMainDish.Schnitzel;
            MainDish mainDish = InitializeDishes.InitializeMainDish(name, quantity, dinerSerialNumber, mainDishType);

            Assert.AreEqual(mainDishType, mainDish.MainDishType);
            Assert.AreEqual(dinerSerialNumber, mainDish.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishTypes.MainDish], mainDish.MainRank);
            Assert.AreEqual(name, mainDish.Name);
            Assert.AreEqual(DishPrices.MainDishPrices[mainDishType], mainDish.Price);
            Assert.AreEqual(quantity, mainDish.Quantity);
            Assert.AreEqual(1, mainDish.SecondRank);
            Assert.AreEqual(DishRanks.MainDishRanks[mainDishType], mainDish.ThirdRank);
        }

        [TestMethod]
        public void InitializeMainDish_SpringChicken()
        {
            string name = "Spring Chicken";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eMainDish mainDishType = eMainDish.SpringChicken;
            MainDish mainDish = InitializeDishes.InitializeMainDish(name, quantity, dinerSerialNumber, mainDishType);

            Assert.AreEqual(mainDishType, mainDish.MainDishType);
            Assert.AreEqual(dinerSerialNumber, mainDish.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishTypes.MainDish], mainDish.MainRank);
            Assert.AreEqual(name, mainDish.Name);
            Assert.AreEqual(DishPrices.MainDishPrices[mainDishType], mainDish.Price);
            Assert.AreEqual(quantity, mainDish.Quantity);
            Assert.AreEqual(1, mainDish.SecondRank);
            Assert.AreEqual(DishRanks.MainDishRanks[mainDishType], mainDish.ThirdRank);
        }
    }
}
