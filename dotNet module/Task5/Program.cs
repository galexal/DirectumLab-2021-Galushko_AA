using System;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
            Console.WriteLine(new StringValue("AAA") == new StringValue("AAA"));
        }
    }
}
