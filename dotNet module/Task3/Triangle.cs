using System;

namespace Task3
{
    public class Triangle : Rectangle
    {
        public int SideC_Length { get; set; }

        public override double Length()
            => this.SideA_Length + this.SideB_Length + this.SideC_Length;

        public override double Area()
        {
            // semi-perimeter
            var sp = (this.SideA_Length + this.SideB_Length
                + this.SideC_Length) / 2;
            return Math.Sqrt(sp * (sp - this.SideA_Length) * (sp - this.SideB_Length)
                * (sp - this.SideC_Length));
        }

        public Triangle() { }

        public Triangle(int sideA_Length, int sideB_Length, int sideC_Length)
        {
            this.SideA_Length = sideA_Length;
            this.SideB_Length = sideB_Length;
            this.SideC_Length = sideC_Length;
        }
    }
}
