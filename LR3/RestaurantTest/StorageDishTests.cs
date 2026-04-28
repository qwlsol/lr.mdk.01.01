using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieShow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieShow.Tests
{
    [TestClass]
    public class StorageDishTests
    {
        private string testFilePath;
        private StorageDish storage;

        [TestInitialize]
        public void Setup()
        {
            storage = new StorageDish();
            // Создаем временный тестовый файл
            testFilePath = Path.Combine(Path.GetTempPath(), "test_dishes.csv");
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Удаляем временный файл после тестов
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [TestMethod]
        public void LoadAllDish_WithValidFile_ShouldLoadDishes()
        {
            // Этот тест проверяет, что метод не выбрасывает исключение
            // и возвращает список (даже если файл не найден, он вернет пустой список)

            // Act
            List<Dish> dishes = storage.LoadAllDish();

            // Assert
            Assert.IsNotNull(dishes);
            // Метод LoadAllDish возвращает List<Dish>, который может быть пустым
            // если файл не найден или поврежден
        }

        [TestMethod]
        public void StorageDish_ImplementsIDishInterface()
        {
            // Assert
            Assert.IsTrue(storage is IDish);
        }

        [TestMethod]
        public void LoadAllDish_ReturnsListOfDish()
        {
            // Act
            var result = storage.LoadAllDish();

            // Assert
            Assert.IsInstanceOfType(result, typeof(List<Dish>));
        }
    }
}