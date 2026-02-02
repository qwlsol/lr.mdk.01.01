using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Dish
    {
        private string name_;
        private double price_;
        private string description_;
        private string ingredients_;
        private string path_;

        public Dish(string name, double price, string description, string ingredients, string path)
        {
            name_ = name;
            price_ = price;
            description_ = description;
            ingredients_ = ingredients;
            path_ = path;
        }
        public string Name
        {
            get { return name_; }
        }
        public string Price
        {
            get { return price_.ToString(); }
        }
        public string Discription
        {
            get { return description_; }
        }
        public string Ingredients
        {
            get { return ingredients_; }
        }
        public string ImagePath
        {
            get { return path_; }
        }
    }
}
