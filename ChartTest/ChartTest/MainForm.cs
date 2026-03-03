using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {

        void FillCartesianChart()
        {
            LineSeries series = new LineSeries
            {
                Title = "График",
                Values = new ChartValues<int> { 2, 6, 4, 10, 7, 16, 2 },

                Stroke = new SolidColorBrush(Colors.Red),
                StrokeThickness = 3,

                PointGeometry = DefaultGeometries.Diamond,
                PointGeometrySize = 8,

                Fill = new LinearGradientBrush(
                    System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                    System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                    90)
            };

            cartesian.Series = new SeriesCollection { series, /*series_2, series_3*/ };

            /// Ось Y
            cartesian.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 1
                },

                MaxValue = 30,
                MinValue = 1
            }              
            );


            /// Ось X
            cartesian.AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                Labels = new[] { "Мар", "Апр", "Май", "Июн", "Июл", "Авг", "Сен" },

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }

        void FillAngular()
        {
            angular.Value = 65;
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Black;
            angular.NeedleFill = Brushes.Blue;
        }

        void FillSolid()
        {
            solid.Value = 40;
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
           
        }
        public MainForm()
        {
            InitializeComponent();

            FillCartesianChart();

            FillAngular();

            FillSolid();
        }
    }
}
