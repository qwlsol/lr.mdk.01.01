using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class OrderedDish
    {
        public Dish dish;
        public int quantity;

        public OrderedDish(Dish baseDish, int dishQuantity)
        {
            dish = baseDish;
            quantity = dishQuantity;
        }
        public decimal CalculateTotal()
        {
            return dish.price * quantity;
        }
    }
}
