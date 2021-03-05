using System;

namespace Task3
{
    public class Ring : Round
    {
        public int InnerRadius { get; set; }

        public Ring(int radius, int innerRadius) : base(radius)
        {
            this.Radius = radius;
            this.InnerRadius = innerRadius;
        }

        public override double Area => (Math.PI * this.Radius * this.Radius)
        - (Math.PI * this.InnerRadius * this.InnerRadius);
    }
}
