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
            for (int i = 0; i < listLength; i++)
            {
                list.Add(rnd.Next(listLength));
            }

            var fs = new FastSearcher(list, 2, 20);

            fs.TaskMaker(x => x < 10);

            for (int i = 0; i < fs.Result.Count; i++)
            {
                Console.WriteLine(fs.Result[i]);
            }
        }
    }
}
