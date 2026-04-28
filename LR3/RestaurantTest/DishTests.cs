using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieShow;

namespace RestaurantTest
{
    [TestClass]
    public class DishTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializePropertiesCorrectly()
        {
            // Arrange
            string expectedName = "Пицца Маргарита";
            int expectedPrice = 450;
            string expectedDescription = "Классическая итальянская пицца";
            string expectedIngredients = "Тесто, томатный соус, моцарелла, базилик";
            string expectedPhoto = @"C:\photos\pizza.jpg";
            string expectedGroup = "Горячее";

            // Act
            Dish dish = new Dish(expectedName, expectedPrice, expectedDescription,
                                expectedIngredients, expectedPhoto, expectedGroup);

            // Assert
            Assert.AreEqual(expectedName, dish.Name);
            Assert.AreEqual(expectedPrice, dish.Price);
            Assert.AreEqual(expectedDescription, dish.Description);
            Assert.AreEqual(expectedIngredients, dish.Ingredients);
            Assert.AreEqual(expectedPhoto, dish.Photo);
            Assert.AreEqual(expectedGroup, dish.Group);
        }

        [TestMethod]
        public void GetInfo_ShouldReturnFormattedString()
        {
            // Arrange
            Dish dish = new Dish("Цезарь", 320, "Салат с курицей",
                                "Курица, салат, соус, сыр пармезан",
                                @"C:\photos\caesar.jpg", "Закуски");

            // Act
            string info = dish.GetInfo();

            // Assert
            Assert.IsTrue(info.Contains("Название: Цезарь"));
            Assert.IsTrue(info.Contains("Категория: Закуски"));
            Assert.IsTrue(info.Contains("Цена: 320"));
            Assert.IsTrue(info.Contains("Описание: Салат с курицей"));
            Assert.IsTrue(info.Contains("Ингредиенты: Курица, салат, соус, сыр пармезан"));
        }

        [TestMethod]
        public void GetInfo_WithDifferentData_ShouldReturnCorrectInfo()
        {
            // Arrange
            Dish dish = new Dish("Борщ", 250, "Свекольный суп",
                                "Свекла, капуста, картофель, мясо",
                                @"C:\photos\borsch.jpg", "Горячее");

            // Act
            string info = dish.GetInfo();

            // Assert
            Assert.IsTrue(info.StartsWith("Название: Борщ"));
            Assert.IsTrue(info.Contains("Категория: Горячее"));
            Assert.IsTrue(info.Contains("Цена: 250"));
        }
    }
}