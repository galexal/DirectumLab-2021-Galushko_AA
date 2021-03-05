using System;
using System.Data;

namespace Task4_2_DataSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var movieStore = new DataSet("MovieStore");
            var moviesTable = new DataTable("Movies");
            movieStore.Tables.Add(moviesTable);

            var idColumn = new DataColumn("Id", Type.GetType("System.Int32"));
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;

            var nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            var priceColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            priceColumn.DefaultValue = 100;
            var discountColumn = new DataColumn("Discount", Type.GetType("System.Decimal"));
            discountColumn.Expression = "Price * 0.2";

            moviesTable.Columns.Add(idColumn);
            moviesTable.Columns.Add(nameColumn);
            moviesTable.Columns.Add(priceColumn);
            moviesTable.Columns.Add(discountColumn);
            moviesTable.PrimaryKey = new DataColumn[] { moviesTable.Columns["Id"] };

            var row = moviesTable.NewRow();
            row.ItemArray = new object[] { null, "Храброе сердце", 300 };
            moviesTable.Rows.Add(row);
            moviesTable.Rows.Add(new object[] { null, "Гладиатор", 170 });


            Console.Write("\tИд \tНазвание \tЦена \tСкидка");
            Console.WriteLine();
            foreach (DataRow r in moviesTable.Rows)
            {
                foreach (var cell in r.ItemArray)
                    Console.Write($"\t{cell}");
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine(GetStringFromDataSet(movieStore, '$', '&'));

            Console.ReadLine();
        }

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
