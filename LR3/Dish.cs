using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Dish
    {
        public string name;
        public string description;
        public decimal price;
        public List<string> ingredients;
        public string imagePath;
        public Dish(string dishName, string dishDescription, decimal dishPrice)
        {
            name = dishName;
            description = dishDescription;
            price = dishPrice;
            ingredients = new List<string>();
            imagePath = "";
        }
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }
    }
}

