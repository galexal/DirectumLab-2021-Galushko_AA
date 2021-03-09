using System;
using System.Collections;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
            Console.WriteLine(new StringValue("AAA") == new StringValue("AAA"));

            var twoComplexes = new ArrayList()
            {
                new ComplexNumber() { Real = 3, Imaginary = 5 },
                new ComplexNumber() { Real = 2, Imaginary = 2 }
            };
            twoComplexes.Sort();
        }
    }
}
