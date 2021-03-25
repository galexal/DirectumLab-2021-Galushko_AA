using NUnit.Framework;
using System;
using System.Data;
using static Task4.DataSetTask;

namespace Task4.Tests
{
    public class DataSetTaskTests
    {
        [Test]
        public void GetRightString()
        {
            var expected = "1$Храброе сердце$300$60,0$2$Гладиатор$170$34,0$Id&Name&Price&Discount&";
            var actual = GetStringFromDataSet(this.GetDataSet(), '$', '&');
            Assert.AreEqual(expected, actual);
        }

        private DataSet GetDataSet()
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
            return movieStore;
        }
    }
}
