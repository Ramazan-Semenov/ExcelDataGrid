using FilterDataGrid_Net4.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Empl> collection { get; set; } = new ObservableCollection<Empl>();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(new Empl { Description = i.ToString(), Name = i.ToString() });
            }
            DataContext = this;
            MyDataGrid.ItemsSource = collection;
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Empl : IColumnsToCalculate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IDictionary<string, double> ToNameCalculate { get; set; } = new Dictionary<string, double>();
    }
}
