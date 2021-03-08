using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class DataSetTask
    {
        public static string GetStringFromDataSet(DataSet dataSet, char valueSeparator,
char columnSeparator)
        {
            string result = string.Empty;
            var dataTable = dataSet.Tables[0];

            foreach (DataRow r in dataTable.Rows)
            {
                foreach (var cell in r.ItemArray)
                    result += $"{valueSeparator}" + cell + $"{valueSeparator} ";
            }
            foreach (DataColumn c in dataTable.Columns)
                result += $"{columnSeparator}" + c.ColumnName + $"{columnSeparator} ";
            return result;
        }
    }
}
