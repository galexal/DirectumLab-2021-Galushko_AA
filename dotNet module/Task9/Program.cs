using System;
using System.Linq;

namespace Task9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reader = new Task8.FileReader("ClientConnectionLog.log");
            var date = new DateTime(2007, 12, 13);
            var result = reader.Where(line => line.Substring(0, 10) == date.ToString("dd.MM.yyyy"))
                .OrderByDescending(time => time.Substring(12, 8));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
