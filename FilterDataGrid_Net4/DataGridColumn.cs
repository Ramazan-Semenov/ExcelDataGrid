using System;
using System.Windows;
using System.Windows.Data;

namespace FilterDataGrid_Net4
{
    public interface IFormula
    {
        string Formula { get; set; }
    }
    public class DataGridTemplateColumn : System.Windows.Controls.DataGridTemplateColumn, IFormula
    {
        #region Public Fields

        /// <summary>
        /// FieldName Dependency Property.
        /// </summary>
        public static readonly DependencyProperty FieldNameProperty =
            DependencyProperty.Register("FieldName", typeof(string), typeof(DataGridTemplateColumn),
                new PropertyMetadata(""));

        /// <summary>
        /// IsColumnFiltered Dependency Property.
        /// </summary>
        public static readonly DependencyProperty IsColumnFilteredProperty =
                    DependencyProperty.Register("IsColumnFiltered", typeof(bool), typeof(DataGridTemplateColumn),
                new PropertyMetadata(false));

        #endregion Public Fields

        #region Public Properties

        public string FieldName
        {
            get => (string)GetValue(FieldNameProperty);
            set => SetValue(FieldNameProperty, value);
        }

        public bool IsColumnFiltered
        {
            get => (bool)GetValue(IsColumnFilteredProperty);
            set => SetValue(IsColumnFilteredProperty, value);
        }
        public string Formula { get; set; }

        #endregion Public Properties
    }

    public class DataGridTextColumn : System.Windows.Controls.DataGridTextColumn, IFormula
    {

        protected override void OnBindingChanged(BindingBase oldBinding, BindingBase newBinding)
        {
            base.OnBindingChanged(oldBinding, newBinding);

        }
        protected override FrameworkElement GenerateElement(System.Windows.Controls.DataGridCell cell, object dataItem)
        {
            Console.WriteLine(dataItem);
            cell.Content = 0;
            return base.GenerateElement(cell, dataItem);
        }
        public DataGridTextColumn()
        {


        }
        #region Public Fields
        public string Formula { get; set; }
        /// <summary>
        /// FieldName Dependency Property.
        /// </summary>
        public static readonly DependencyProperty FieldNameProperty =
            DependencyProperty.Register("FieldName", typeof(string), typeof(DataGridTextColumn),
                new PropertyMetadata(""));

        /// <summary>
        /// IsColumnFiltered Dependency Property.
        /// </summary>
        public static readonly DependencyProperty IsColumnFilteredProperty =
                    DependencyProperty.Register("IsColumnFiltered", typeof(bool), typeof(DataGridTextColumn),
                new PropertyMetadata(false));

        #endregion Public Fields

        #region Public Properties

        public string FieldName
        {
            get => (string)GetValue(FieldNameProperty);
            set => SetValue(FieldNameProperty, value);
        }

        public bool IsColumnFiltered
        {
            get => (bool)GetValue(IsColumnFilteredProperty);
            set => SetValue(IsColumnFilteredProperty, value);
        }

        #endregion Public Properties
    }

    public class DataGridCheckBoxColumn : System.Windows.Controls.DataGridCheckBoxColumn, IFormula
    {
        #region Public Fields
        public string Formula { get; set; }
        /// <summary>
        /// FieldName Dependency Property.
        /// </summary>
        public static readonly DependencyProperty FieldNameProperty =
            DependencyProperty.Register("FieldName", typeof(string), typeof(DataGridCheckBoxColumn),
                new PropertyMetadata(""));

        /// <summary>
        /// IsColumnFiltered Dependency Property.
        /// </summary>
        public static readonly DependencyProperty IsColumnFilteredProperty =
            DependencyProperty.Register("IsColumnFiltered", typeof(bool), typeof(DataGridCheckBoxColumn),
                new PropertyMetadata(false));

        #endregion Public Fields

        #region Public Properties

        public string FieldName
        {
            get => (string)GetValue(FieldNameProperty);
            set => SetValue(FieldNameProperty, value);
        }

        public bool IsColumnFiltered
        {
            get => (bool)GetValue(IsColumnFilteredProperty);
            set => SetValue(IsColumnFilteredProperty, value);
        }

        #endregion Public Properties
    }

}
