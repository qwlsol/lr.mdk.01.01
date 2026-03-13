using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksInCafeLibrary.Analysis;
using DrinksInCafeLibrary.Model;
using DrinksInCafeLibrary.View;

namespace DrinksInCafeLibrary.Presenter
{
    public class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();
        private List<ISalesView> views_;

        public SalesPresenter(List<ISalesView> views)
        {
            views_ = views;
            model_.Load();
        }

        public void ShowSalesByItem(string itemName)
        {
            List<Sale> sales = model_.LoadSalesForItem(itemName);
            foreach (ISalesView view in views_)
            {
                view.Show(sales);
            }
        }

        public List<Item> GetAllItems()
        {
            return model_.GetAllItems();
        }

        public double GetProfitPercentByItem(Item selectedItem)
        {
            return Math.Round(ProfitAnalyzer.CalculateProfitPercentByItem(selectedItem.Name, model_), 2);
        }

        public double GetTotalProfit()
        {
            return model_.GetTotalProfit();
        }
    }
}
