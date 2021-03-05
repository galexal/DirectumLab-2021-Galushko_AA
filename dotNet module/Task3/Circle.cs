using System;

namespace Task3
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public double Length => 2 * Math.PI * this.Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }
    }
}
