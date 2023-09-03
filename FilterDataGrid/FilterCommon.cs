using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Runtime.Serialization;

namespace FilterDataGrid
{
    public sealed class FilterCommon : NotifyProperty
    {
        #region Private Fields

        private bool isFiltered;

        #endregion Private Fields

        #region Public Constructors

        public FilterCommon()
        {
            PreviouslyFilteredItems = new HashSet<object>(EqualityComparer<object>.Default);
        }

        #endregion Public Constructors

        #region Public Properties

        public HashSet<object> PreviouslyFilteredItems { get; set; }

        public string FieldName { get; set; }

        public Button FilterButton { get; set; }
        public Loc Translate { get; set; }
        public Type FieldType { get; set; }
        public bool IsFiltered
        {
            get => isFiltered;
            set
            {
                isFiltered = value;
                OnPropertyChanged(nameof(IsFiltered));
            }
        }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        ///     Add the filter to the predicate dictionary
        /// </summary>
        public void AddFilter(Dictionary<string, Predicate<object>> criteria)
        {
            if (IsFiltered) return;

            // predicate of filter
            bool Predicate(object o)
            {
                var value = FieldType == typeof(DateTime)
                    ? ((DateTime?)o.GetPropertyValue(FieldName))?.Date
                    : o.GetPropertyValue(FieldName);

                return !PreviouslyFilteredItems.Contains(value);
            }

            // add to list of predicates
            criteria.Add(FieldName, Predicate);

            IsFiltered = true;
        }

        #endregion Public Methods
    }
}
