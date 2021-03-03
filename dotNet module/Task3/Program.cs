using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var circle = new Circle(5);
            Console.WriteLine(circle.Length);
            var round = new Round(5);
            Console.WriteLine(round.Square());
            Console.WriteLine(round.Length);
            var ring = new Ring(5, 3);
            Console.WriteLine(ring.Square());
        }
    }
}
