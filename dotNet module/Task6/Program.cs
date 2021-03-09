using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    public class Program
    {
        public static int Counter(string path, DateTime startDate, DateTime endDate)
        {
            string data;
            using (StreamReader sr = new StreamReader(path))
            {
                data = sr.ReadToEnd();
            }
            Regex regex = new Regex(@"\d{1,2}.\d{1,2}.\d{4}");
            var count = 0;

            MatchCollection matches = regex.Matches(data);
            foreach (Match match in matches)
                if (DateTime.Parse(match.Value) >= startDate
                    && DateTime.Parse(match.Value) <= endDate)
                    count++;

            return count;
        }
        
        public static void Main(string[] args)
        {
            var path = "ClientConnectionLog.log";
            var startDate = new DateTime(2007, 12, 19);
            var endDate = new DateTime(2008, 01, 22);

            Console.WriteLine($"Найдено {Counter(path,startDate,endDate)} совпадений");
        }
    }
}
