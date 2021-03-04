using System;

namespace Task3
{
    public class Triangle : Rectangle
    {
        public int SideC { get; set; }

        public override double Length
            => this.SideA + this.SideB + this.SideC;

        public override double Area
        {
            get
            {
                var sp = (this.SideA + this.SideB
                    + this.SideC) / 2;
                return Math.Sqrt(sp * (sp - this.SideA) * (sp - this.SideB)
                    * (sp - this.SideC));
            }
        }

        public Triangle(int sideA, int sideB, int sideC) : base(sideA, sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
    }
}
