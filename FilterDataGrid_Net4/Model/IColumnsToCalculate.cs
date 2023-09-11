using System.Collections.Generic;

namespace FilterDataGrid_Net4.Model
{
    public interface IColumnsToCalculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IDictionary<string, double> ToNameCalculate { get; set; }
        //double Calculate { get; set; }   
        //string Name { get; set; }
    }
}
