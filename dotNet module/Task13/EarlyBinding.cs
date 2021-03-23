using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task13
{
    /// <summary>
    /// Раннее связывание.
    /// </summary>
    public class EarlyBinding
    {
        /// <summary>
        /// Запись в Excel таблицы умножения.
        /// </summary>
        public static void Main()
        {
            var excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);
            var excelappworkbooks = excelapp.Workbooks;
            var excelappworkbook = excelappworkbooks[1];
            var excelsheets = excelappworkbook.Worksheets;
            var excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            for (var m = 1; m < 9; m++)
            {
                for (var n = 1; n < 9; n++)
                {
                    var excelcells = (Excel.Range)excelworksheet.Cells[m, n];
                    excelcells.Value2 = m * n;
                }
            }
        }
    }
}
