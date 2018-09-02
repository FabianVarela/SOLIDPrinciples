namespace OpenClose.Class
{
    using OpenClose.Abstract;

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() => Width * Height;
    }
}
