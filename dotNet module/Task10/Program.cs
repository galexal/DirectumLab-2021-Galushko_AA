using System;
using System.Collections.Generic;

namespace Task10
{
    /// <summary>
    /// Класс с мeтодом Main.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа программы.
        /// </summary>
        public static void Main()
        {
            var rnd = new Random();
            var list = new List<int>();
            var listLength = 100;
            for (int i = listLength; i >= 0; i--)
            {
                // list.Add(rnd.Next(listLength));
                list.Add(i);
            }

            var fs = new FastSearcher<int>(list, 4, 25);

            var result = fs.Search(x => x < 10);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
