using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrinksInCafeLibrary;
using DrinksInCafeLibrary.Presenter;
using DrinksInCafeLibrary.View;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace LR_сharts
{
    public partial class Form1 : Form
    {
        private SalesPresenter presenter_;

        public Form1()
        {
            InitializeComponent();
            var views = new List<ISalesView> { new SalesCartesianChart(cartesianChart1) };
            presenter_ = new SalesPresenter(views);
            FillDrinksList();
            UpdatePieChart();

        }

        private void FillDrinksList()
        {
            var items = presenter_.GetAllItems();
            listBoxDrinks.DataSource = items;
            listBoxDrinks.DisplayMember = "Name";

            if (listBoxDrinks.Items.Count > 0)
            {
                listBoxDrinks.SelectedIndex = 0;
            }
        }
        private void UpdatePieChart()
        {
            var items = presenter_.GetAllItems();
            var seriesCollection = new LiveCharts.SeriesCollection();

            foreach (Item item in items)
            {
                double percent = presenter_.GetProfitPercentByItem(item);

                var pieSeries = new LiveCharts.Wpf.PieSeries
                {
                    Title = $"{item.Name} ({percent:F1}%)",
                    Values = new LiveCharts.ChartValues<double> { percent }
                };
                seriesCollection.Add(pieSeries);
            }

            pieChart.Series = seriesCollection;
        }

        private void listBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrinks.SelectedItem is Item selectedItem)
            {
                presenter_.ShowSalesByItem(selectedItem.Name);
            }
        }
    }
}   