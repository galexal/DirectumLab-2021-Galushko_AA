using System;
using System.Reflection;

namespace Task13
{
    /// <summary>
    /// Позднее связывание.
    /// </summary>
    public class LateBinding
    {
        /// <summary>
        /// Запись в Excel таблицы умножения.
        /// </summary>
        public static void Main()
        {
            dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID(
              "Excel.Application"));
            excel.Visible = true;
            var workbooks = excel.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, excel, null);
            var workbook = workbooks.GetType().InvokeMember("Add", BindingFlags.InvokeMethod, null, workbooks, null);
            var worksheets = workbook.GetType().InvokeMember("Worksheets", BindingFlags.GetProperty, null, workbook, null);
            var args = new object[1];
            args[0] = 1;
            var worksheet = worksheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, worksheets, args);
            for (var m = 1; m < 9; m++)
            {
                for (var n = 1; n < 9; n++)
                {
                    // Не могу разобраться, почему все значения в первую строку записываются
                    var range = worksheet.GetType().InvokeMember("Cells", BindingFlags.GetProperty, null, worksheet, new object[] { $"{m},{n}" });
                    range.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, range, new object[] { $"{m * n}" });
                }
            }
        }
    }
}
