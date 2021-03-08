using System;
using System.Diagnostics;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region StringVsStringBuilder
            var watch = new Stopwatch();
            watch.Start();
            var str = StringVsStringBuilder.StringConcatenation();
            watch.Stop();
            Console.WriteLine($"Длительность конкатенации String:" +
                $"{watch.ElapsedMilliseconds} мс");
            watch.Reset();
            var rnd = new Random();
            var startIndex = rnd.Next(0, str.Length);
            watch.Start();
            str = StringVsStringBuilder.StringConcatenation().Substring(startIndex);
            watch.Stop();
            Console.WriteLine($"Длительность конкатенации с получением подстроки String:" +
                $"{watch.ElapsedMilliseconds} мс");

            watch = new Stopwatch();
            watch.Start();
            var builder = StringVsStringBuilder.StringBuilderConcatenation();
            watch.Stop();
            Console.WriteLine($"Длительность конкатенации StringBuilder:" +
                $"{watch.ElapsedMilliseconds} мс");
            watch.Reset();
            watch.Start();
            str = StringVsStringBuilder.StringBuilderConcatenation()
                .ToString(startIndex, builder.Length - startIndex);
            watch.Stop();
            Console.WriteLine($"Длительность конкатенации с получением подстроки StringBuilder:" +
                $"{watch.ElapsedMilliseconds} мс");
            #endregion

            #region Logger
            /*
            using (Logger logger = new Logger("test.txt"))
            {
                logger.WriteString("test");
            }
            */
            #endregion


            #region AccessRights
            /*
            var accessRights = Access.AccessRights.Edit | Access.AccessRights.Add;
            var accessRights2 = Access.AccessRights.AccessDenied | Access.AccessRights.Add;
            Access.PrintAccessRights(accessRights);
            Access.PrintAccessRights(accessRights2);
            */
            #endregion

            #region DataSet
            /*
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

            Console.WriteLine(DataSetTask.GetStringFromDataSet(movieStore, '$', '&'));
            */
            #endregion
        }
    }
}
