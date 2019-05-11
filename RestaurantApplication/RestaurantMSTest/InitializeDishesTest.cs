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
            string name = "Chicken Nuggets";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eAppetizer appetizerType = eAppetizer.ChickenNuggets;
            Appetizer appetizer = InitializeDishes.InitializeAppetizer(name, quantity, dinerSerialNumber, appetizerType);
            
            Assert.AreEqual(appetizerType, appetizer.AppetizerType);
            Assert.AreEqual(dinerSerialNumber, appetizer.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishYypes.Appetizer], appetizer.MainRank);
            Assert.AreEqual(name, appetizer.Name);
            Assert.AreEqual(DishPrices.AppetizerPrices[appetizerType], appetizer.Price);
            Assert.AreEqual(quantity, appetizer.Quantity);
            Assert.AreEqual(1, appetizer.SecondRank);
            Assert.AreEqual(DishRanks.AppetizerRanks[appetizerType], appetizer.ThirdRank);            
        }

        [TestMethod]
        public void InitializeMainDish()
        {
            string name = "Schnitzel";
            int quantity = 2;
            int dinerSerialNumber = 1;
            eMainDish mainDishType = eMainDish.Schnitzel;
            MainDish mainDish = InitializeDishes.InitializeMainDish(name, quantity, dinerSerialNumber, mainDishType);

            Assert.AreEqual(mainDishType, mainDish.MainDishType);
            Assert.AreEqual(dinerSerialNumber, mainDish.DinerSerialNumber);
            Assert.AreEqual(DishRanks.DishesRank[eDishYypes.MainDish], mainDish.MainRank);
            Assert.AreEqual(name, mainDish.Name);
            Assert.AreEqual(DishPrices.MainDishPrices[mainDishType], mainDish.Price);
            Assert.AreEqual(quantity, mainDish.Quantity);
            Assert.AreEqual(1, mainDish.SecondRank);
            Assert.AreEqual(DishRanks.MainDishRanks[mainDishType], mainDish.ThirdRank);
        }    
    }
}
