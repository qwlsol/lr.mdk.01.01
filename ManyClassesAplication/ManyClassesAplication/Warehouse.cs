using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    public class Warehouse
    {
        private int _id;
        private Dictionary<Product, int> productCount_ = new Dictionary<Product, int>();
        private string location_;

        public void SetId(int id)
        {
            _id = id;
        }
        public int GetId()
        {
            return _id;
        }
        public void SetLocation(string location)
        {
            location_ = location;
        }
        public string GetLocation()
        {
            return location_;
        }
        public void SetProductCount(Product product, int count)
        {
            productCount_.Add(product, count);
        }
        public Dictionary<Product, int> GetProductCount()
        {
            return productCount_;
        }
        public void PrintAllProduct()
        {
            Console.WriteLine("Товары на складе:");
            foreach (Product product in productCount_.Keys)
            { 
            int count = productCount_[product]; 
                Console.WriteLine(product.GetName(), product.GetPrice(), count);
            } 

        }
        public void PrintTotalMoney() 
        {
            double money = 0;
            foreach (Product product in productCount_.Keys)
            {
                money += product.GetPrice() * productCount_[product];
            }
            Console.WriteLine($"Общая стоимость товаров: {money} руб.");
        }
    }
}
