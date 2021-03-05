using System;

namespace Task3
{
    public class Round : Circle
    {
        public virtual double Area => Math.PI * this.Radius * this.Radius;

        public Round(int radius) : base(radius)
        {
            this.Radius = radius;
        }
    }
}
