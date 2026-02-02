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

        public Dish(string name, double price, string description, string ingredients)
        {
            name_ = name;
            price_ = price;
            description_ = description;
            ingredients_ = ingredients;
        }
        public string Name
        {
            get { return name_; }
        }
    }
}
