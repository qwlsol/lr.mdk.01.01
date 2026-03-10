using LiveCharts.Wpf;
using LiveCharts;
using SalesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using SalesLibrary.Views;
using SalesLibrary.Presenters;

namespace ChartTest.Views
{
    internal class SalesPieChart : LiveCharts.WinForms.PieChart
                                       
    {
        private SalesPresenter presenter_;
        public void SetPresenter(SalesPresenter presenter)
        { 
        presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Item> allItems = presenter_.GetAllItems();
            SeriesCollection seriesData = new SeriesCollection();

            foreach (Item item in allItems)
            {
                seriesData.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double>() { presenter_.GetProfitPercentByItem(item) }
                });
            }
  
            Series = seriesData;
            
        
        }
    }
}

