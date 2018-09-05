namespace LiskovSubstitution
{
    using LiskovSubstitution.Class;

    public class LSPAreaCalculator
    {
        public double SetCircleArea(int majorAxis, int minorAxis)
        {
            Circle circle = new Circle();
            circle.SetMajorAxis(majorAxis);
            circle.SetMinorAxis(minorAxis);

            return circle.Area();
        }

        public int SetSquareArea(int breadth, int lenght)
        {
            Square square = new Square();
            square.SetBreadth(breadth);
            square.SetLength(lenght);

            return square.GetArea();
        }
    }
}
