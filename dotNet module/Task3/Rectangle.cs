namespace Task3
{
    public class Rectangle : Square
    {
        public int SideB { get; set; }

        public override double Length => 2 * (this.SideA + this.SideB);

        public override double Area => this.SideA * this.SideB;


        public Rectangle(int sideA, int sideB) : base(sideA)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
    }
}
