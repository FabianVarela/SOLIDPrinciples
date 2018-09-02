namespace OpenClose.Class
{
    using OpenClose.Abstract;

    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area() => Height * Width * 0.5;
    }
}
