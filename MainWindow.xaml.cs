using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            var dataLabels = false;

            SeriesCollection = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> { 105,207,407,450,650,858,1053,1103,1153,1223 },
                    StackMode = StackMode.Values,
                    DataLabels = dataLabels,
                    Title = "EMEA"
                }
            };

            Labels = new string[] { "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013" };

            DataContext = this;
        }
    }
}
