using System.Collections.Generic;

namespace FilterDataGrid.Model
{
    public interface IColumnsToCalculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IDictionary<string, object> ToNameCalculate();
        //double Calculate { get; set; }   
        //string Name { get; set; }
    }

}
