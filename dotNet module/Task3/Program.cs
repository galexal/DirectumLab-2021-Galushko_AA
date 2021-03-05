using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            Console.WriteLine(circle.Length);
            var round = new Round(5);
            Console.WriteLine(round.Area);
            Console.WriteLine(round.Length);
            var ring = new Ring(5, 3);
            Console.WriteLine(ring.Area);
            var square = new Square(5);
            Console.WriteLine(square.Length);
            Console.WriteLine(square.Area);
            var rectangle = new Rectangle(5, 4);
            Console.WriteLine(rectangle.Length);
            Console.WriteLine(rectangle.Area);
            var triangle = new Triangle(5, 4, 3);
            Console.WriteLine(triangle.Length);
            Console.WriteLine(triangle.Area);
        }
    }
}
