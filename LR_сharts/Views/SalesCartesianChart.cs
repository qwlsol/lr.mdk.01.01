using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using DrinksInCafeLibrary;
using DrinksInCafeLibrary.View;
using LiveCharts.Wpf;
using LiveCharts;

namespace LR_сharts
{
    public class SalesCartesianChart : LiveCharts.WinForms.CartesianChart, ISalesView
    {
        private LiveCharts.WinForms.CartesianChart chart_;

        public SalesCartesianChart(LiveCharts.WinForms.CartesianChart chart)
        {
           chart_ = chart;
        }

        public void Show(List<Sale> sales)
        {
            if (sales == null || sales.Count == 0) return;

            chart_.Series = new LiveCharts.SeriesCollection();
            chart_.AxisX.Clear();
            chart_.AxisY.Clear();

            var lineSeries = new LiveCharts.Wpf.LineSeries
            {
                Title = "Продажи по дням",
                Values = new LiveCharts.ChartValues<int>(),
                PointGeometry = LiveCharts.Wpf.DefaultGeometries.Circle,
                PointGeometrySize = 10,
                StrokeThickness = 2
            };

            string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

            for (int i = 0; i < sales.Count; i++)
            {
                lineSeries.Values.Add(sales[i].Count);
            }

            chart_.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Дни недели",
                Labels = days,
                Separator = new LiveCharts.Wpf.Separator { IsEnabled = false }
            });

            chart_.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Количество продаж",
                LabelFormatter = value => value.ToString("N0"),
                MinValue = 0
            });

            int maxValue = 0;
            foreach (var sale in sales)
            {
                if (sale.Count > maxValue) maxValue = sale.Count;
            }
            chart_.AxisY[0].MaxValue = maxValue + 5;

            chart_.Series.Add(lineSeries);
        }
    }
}