namespace Task3
{
    public class Square : Shape
    {
        public int SideA_Length { get; set; }

        public virtual double Length() => 4 * this.SideA_Length;

        public virtual double Area() => this.SideA_Length * this.SideA_Length;

        public Square() { }

        public Square(int sideA_Length)
        {
            this.SideA_Length = sideA_Length;
        }
    }
}
