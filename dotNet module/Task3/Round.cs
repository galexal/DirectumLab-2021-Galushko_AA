using System;

namespace Task3
{
    public class Round : Circle
    {
        public virtual double Area() => Math.PI * this.OuterRadius * this.OuterRadius;

        public Round() { }

        public Round(int outerRadius)
        {
            this.OuterRadius = outerRadius;
        }
    }
}
