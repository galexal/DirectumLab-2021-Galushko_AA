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
            var result = new StringBuilder();
            var dataTable = dataSet.Tables[0];

            foreach (DataRow r in dataTable.Rows)
            {
                foreach (var cell in r.ItemArray)
                    result.Append(cell + valueSeparator.ToString());
            }
            foreach (DataColumn c in dataTable.Columns)
                result.Append(c.ColumnName + columnSeparator.ToString());
            return result.ToString();
        }
    }
}
