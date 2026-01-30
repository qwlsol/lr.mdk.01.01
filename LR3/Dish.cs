
namespace LR3
{
    public class Dish
    {
        private string name_;
        private string description_;
        private decimal price_;
        private string ingredients_;

        public Dish(string name, string description, decimal price, string ingredients)
        {
            name_ = name;
            description_ = description;
            price_ = price;
            ingredients_ = ingredients;
        }

    }
}
