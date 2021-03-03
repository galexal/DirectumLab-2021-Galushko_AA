namespace Task3
{
    public class Rectangle : Square
    {
        public int SideB_Length { get; set; }

        public override double Length() => 2 * (this.SideA_Length + this.SideB_Length);

        public override double Area() => this.SideA_Length * this.SideB_Length;

        public Rectangle() { }

        public Rectangle(int sideA_Length, int sideB_Length)
        {
            this.SideA_Length = sideA_Length;
            this.SideB_Length = sideB_Length;
        }
    }
}
