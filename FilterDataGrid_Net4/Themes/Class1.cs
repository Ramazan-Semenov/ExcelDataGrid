using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace FilterDataGrid_Net4.Themes
{
    public enum CommandContextMenu
    {
        Asc = 0,
        Desc = 1,
        SortColor = 2,
        Clear_Filter = 3,


    }
    public partial class Class1
    {
        private void DataGridCell_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            DataGridCell_MouseRightButtonDown?.Invoke(sender, e);
        }
        private void AscDescClick(object sender, RoutedEventArgs e)
        {

            AscDescClickEvent?.Invoke((sender as Button).CommandParameter as DataGridColumnHeader, (CommandContextMenu)(sender as Button).Tag);
        }
        private void AddColumnClick(object sender, RoutedEventArgs e)
        {

            AddColumnClickEvent?.Invoke(sender, e);
        }
        private void UpdateColumnClick(object sender, RoutedEventArgs e)
        {

            //UpdateColumnClickEvent?.Invoke(sender, e, (sender as Button).CommandParameter as DataGridColumnHeader);

            Console.WriteLine((((sender as Button).CommandParameter as System.Windows.Controls.Primitives.Popup).PlacementTarget as System.Windows.Controls.DataGridCell).Column);
        }
        public static Action<DataGridColumnHeader, CommandContextMenu> AscDescClickEvent;
        public static event Action<object, MouseButtonEventArgs> DataGridCell_MouseRightButtonDown;

        public static event Action<object, RoutedEventArgs> AddColumnClickEvent;
        //  public static event Action<object, RoutedEventArgs, DataGridColumnHeader> UpdateColumnClickEvent;

    }
}
