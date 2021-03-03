using System;

namespace Task3
{
    public class Ring : Round
    {
        public int InnerRadius { get; set; }

        public Ring() { }

        public Ring(int outerRadius, int innerRadius)
        {
            this.OuterRadius = outerRadius;
            this.InnerRadius = innerRadius;
        }

        public override double Area() => (Math.PI * this.OuterRadius * this.OuterRadius)
        - (Math.PI * this.InnerRadius * this.InnerRadius);
    }
}
