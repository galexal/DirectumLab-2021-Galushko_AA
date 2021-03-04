namespace Task3
{
    public class Square : Shape
    {
        public int SideA { get; set; }

        public virtual double Length => 4 * this.SideA;

        public virtual double Area => this.SideA * this.SideA;

        public Square(int sideA_Length)
        {
            this.SideA = sideA_Length;
        }
    }
}
