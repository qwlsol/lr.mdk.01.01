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

namespace ChartTest.Views
{
    internal class SalesPieChart : LiveCharts.WinForms.PieChart,
                                       ISalesView
    {
        private LineSeries seriesData_;
        public SalesPieChart()
        {
            seriesData_ = new LineSeries
            {
                Title = "Продажи",

                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

                Fill = new LinearGradientBrush(
                        System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                        System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                        90)
            };

            /// Ось Y
            AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 1
                },

                MinValue = 0
            }
            );


            /// Ось X
            AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }
        public void Show(List<Sale> sales)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})",
                                                    chartPoint.Y, chartPoint.Participation);
            SeriesCollection piechartData = new SeriesCollection
            new PieSeries
            {
                Title = "Конфетки Заоблачные",
                Values = new ChartValues<double> { 40 },
                DataLabels = true,
                LabelPoint = labelPoint,
                Fill = System.Windows.Media.Brushes.Green
            },
        new PieSeries
        {
            Title = "Зефирка Воздушная",
            Values = new ChartValues<double> { 60 },
            DataLabels = true,
            LabelPoint = labelPoint,
            Fill = System.Windows.Media.Brushes.Blue
        }
        };

    
        
    }
}

