using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Circle : Shape
    {
        public int OuterRadius { get; set; }
        public double Length => 2 * Math.PI * this.OuterRadius;
        public Circle() { }
        public Circle(int outerRadius)
        {
            this.OuterRadius = outerRadius;
        }
    }
}
