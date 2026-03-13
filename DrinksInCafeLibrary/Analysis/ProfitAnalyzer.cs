using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksInCafeLibrary.Model;

namespace DrinksInCafeLibrary.Analysis
{
    public class ProfitAnalyzer
    {
        public static double CalculateProfitPercentByItem(string itemName, SalesModel model)
        {
            var itemSales = model.LoadSalesForItem(itemName);
            Item targetItem = model.GetItem(itemName);
            if (targetItem == null)
            {
                return 0.0;
            }
            double itemTotal = itemSales.Sum(sale => sale.Count * targetItem.Price);

            double total = model.GetTotalProfit();
            if (total == 0.0)
            {
                return 0.0;
            }

            return itemTotal / total * 100.0;
        }
    }
}
