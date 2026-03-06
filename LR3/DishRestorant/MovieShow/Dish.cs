using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShow
{
    public class Dish
    {
        private string name_;
        private int price_;
        private string description_;
        private string ingredients_;
        private string photo_;
        private string group_;

        public Dish(string name, int price, string description, string ingredients, string photo, string group)
        {
            name_ = name;
            price_ = price;
            description_ = description;
            ingredients_ = ingredients;
            photo_ = photo;
            group_ = group;
        }

        public string Name
        { get { return name_; } }

        public int Price
        { get { return price_; } }

        public string Description
        { get { return description_; } }

        public string Ingredients
        { get { return ingredients_; } }

        public string Photo
        { get { return photo_; } }

        public string Group
        { get { return group_; } }

        public string GetInfo()
        {
            return $"Название: {name_}\nКатегория: {group_}\nЦена: {price_}\nОписание: {description_}\nИнгредиенты: {ingredients_}";
        }
    }
}