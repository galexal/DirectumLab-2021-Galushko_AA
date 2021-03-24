using System;

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
        public static void FillTable()
        {
            dynamic excelapp = Activator.CreateInstance(Type.GetTypeFromProgID(
              "Excel.Application"));

            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);
            var excelappworkbooks = excelapp.Workbooks;
            var excelappworkbook = excelappworkbooks[1];
            var excelsheets = excelappworkbook.Worksheets;
            var excelworksheet = excelsheets[1];
            for (var m = 1; m < 9; m++)
            {
                for (var n = 1; n < 9; n++)
                {
                    var excelcells = excelworksheet.Cells[m, n];
                    excelcells.Value2 = m * n;
                }
            }
        }
    }
}
