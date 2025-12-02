using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    public class Product
    {
        private string name_;
        private double price_;

        public void SetName(string name)
        {
            name_ = name;
        }
        public string GetName()
        {
            return name_;
        }
        public void SetPrice(double price)
        {
            price_ = price;
        }
        public double GetPrice()
        {
            return price_;
        }
    }
}
