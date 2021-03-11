using System;

namespace Task8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMax(1, 2, 3));
            Console.WriteLine(GetMax("A", "BC", "CDE"));
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
