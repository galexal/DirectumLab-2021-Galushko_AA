using System;
using System.Collections.Generic;

namespace Task8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMax(1, 2, 3));
            Console.WriteLine(GetMax("A", "BC", "CDE"));
            Console.WriteLine();

            var list = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var dictionary = new Dictionary<string, string>()
            {
                ["red"] = "красный",
                ["green"] = "зеленый",
                ["yellow"] = "желтый"
            };
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} переводится как {item.Value}");
            }

            var lines = new LinesIterator("ClientConnectionLog.log");
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
        }

        public static T GetMax<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) < 0)
            {
                if (secondValue.CompareTo(thirdValue) < 0) return thirdValue;
                else return secondValue;
            }
            else
            {
                if (firstValue.CompareTo(thirdValue) < 0) return thirdValue;
                else return firstValue;
            }
        }
    }
}
