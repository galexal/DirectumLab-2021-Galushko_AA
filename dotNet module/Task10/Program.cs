using System;
using System.Collections.Generic;

namespace Task10
{
    public class Program
    {
        public static void Main()
        {
            var rnd = new Random();
            var list = new List<int>();
            var listLength = 100;
            for (int i = listLength; i >= 0; i--)
            {
                //list.Add(rnd.Next(listLength));
                list.Add(i);
            }

            var fs = new FastSearcher<int>(list, 2, 10);

            var result = fs.Search(x => x < 10);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
