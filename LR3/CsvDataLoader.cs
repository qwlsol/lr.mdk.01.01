using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class CsvDataLoader : IDataLoader
    {
        public Dictionary<string, List<Dish>> LoadData()
        {
            Dictionary<string, List<Dish>> dishes = new Dictionary<string, List<Dish>>();

            
            string[] lines = File.ReadAllLines("D:\\П-30\\реп\\LR3\\data.csv");

            foreach (string line in lines)
            {
               
                string[] parts = line.Split(';');

                if (parts.Length >= 6)
                {
                    string group = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    string ingredients = parts[3];
                    double price = Convert.ToDouble(parts[4]);
                    string imagePath = parts[5];

                    Dish dish = new Dish(name, price, description, ingredients, imagePath);

                    if (!dishes.ContainsKey(group))
                    {
                        dishes[group] = new List<Dish>();
                    }

                    dishes[group].Add(dish);
                }
            }

            return dishes;
        }
    }
}
