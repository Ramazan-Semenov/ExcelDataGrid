using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Empl> collection { get; set; }=new ObservableCollection<Empl>();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                collection.Add(new Empl { Description=i.ToString(), Name= i.ToString() });
            }
            DataContext = this;
            MyDataGrid.ItemsSource = collection;
        }
    }
    public class Empl
    {
        public string Name { get; set; }
        public string Description { get; set; }
         
    }
}
