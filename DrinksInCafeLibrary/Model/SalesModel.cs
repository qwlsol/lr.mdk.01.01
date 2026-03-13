using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInCafeLibrary.Model
{
    public class SalesModel
    {
        private Dictionary<Item, List<Sale>> salesByItems_ =
                new Dictionary<Item, List<Sale>>();

        public void AddSales(Item item, List<Sale> sales)
        {
            if (salesByItems_.ContainsKey(item))
            {
                salesByItems_[item].AddRange(sales);
            }
            else
            {
                salesByItems_.Add(item, sales);
            }
        }

        public List<Sale> LoadSalesForItem(string itemName)
        {
            List<Item> allItems = salesByItems_.Keys.ToList();
            Item targetItem = allItems.Find(item => item.Name == itemName);
            if (targetItem != null)
            {
                return salesByItems_[targetItem];
            }
            return new List<Sale>();
        }

        public bool Load()
        {
            AddSales(new Item { Name = "Кофе", Price = 150 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 3, 1), Count = 45 },
                    new Sale {Time = new DateTime(2026, 3, 2), Count = 52 },
                    new Sale {Time = new DateTime(2026, 3, 3), Count = 48 },
                    new Sale {Time = new DateTime(2026, 3, 4), Count = 55 },
                    new Sale {Time = new DateTime(2026, 3, 5), Count = 60 },
                    new Sale {Time = new DateTime(2026, 3, 6), Count = 70 },
                    new Sale {Time = new DateTime(2026, 3, 7), Count = 65 },
                });

            AddSales(new Item { Name = "Чай", Price = 100 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 3, 1), Count = 30 },
                    new Sale {Time = new DateTime(2026, 3, 2), Count = 28 },
                    new Sale {Time = new DateTime(2026, 3, 3), Count = 32 },
                    new Sale {Time = new DateTime(2026, 3, 4), Count = 35 },
                    new Sale {Time = new DateTime(2026, 3, 5), Count = 40 },
                    new Sale {Time = new DateTime(2026, 3, 6), Count = 38 },
                    new Sale {Time = new DateTime(2026, 3, 7), Count = 42 },
                });

            // Сок
            AddSales(new Item { Name = "Сок", Price = 180 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 3, 1), Count = 20 },
                    new Sale {Time = new DateTime(2026, 3, 2), Count = 18 },
                    new Sale {Time = new DateTime(2026, 3, 3), Count = 22 },
                    new Sale {Time = new DateTime(2026, 3, 4), Count = 25 },
                    new Sale {Time = new DateTime(2026, 3, 5), Count = 28 },
                    new Sale {Time = new DateTime(2026, 3, 6), Count = 30 },
                    new Sale {Time = new DateTime(2026, 3, 7), Count = 27 },
                });

            AddSales(new Item { Name = "Лимонад", Price = 120 },
                new List<Sale>() {
                    new Sale {Time = new DateTime(2026, 3, 1), Count = 15 },
                    new Sale {Time = new DateTime(2026, 3, 2), Count = 18 },
                    new Sale {Time = new DateTime(2026, 3, 3), Count = 20 },
                    new Sale {Time = new DateTime(2026, 3, 4), Count = 22 },
                    new Sale {Time = new DateTime(2026, 3, 5), Count = 25 },
                    new Sale {Time = new DateTime(2026, 3, 6), Count = 35 },
                    new Sale {Time = new DateTime(2026, 3, 7), Count = 30 },
                });

            return true;
        }

        public List<Item> GetAllItems()
        {
            return salesByItems_.Keys.ToList();
        }

        public double GetTotalProfit()
        {
            double result = 0.0;
            foreach (var keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                result += keyValue.Value.Sum(sale => sale.Count * item.Price);
            }
            return result;
        }

        public Item GetItem(string itemName)
        {
            foreach (var keyValue in salesByItems_)
            {
                Item item = keyValue.Key;
                if (item.Name == itemName)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
