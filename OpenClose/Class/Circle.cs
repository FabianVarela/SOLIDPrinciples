namespace OpenClose.Class
{
    using OpenClose.Abstract;
    using System;

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area() => Radius * Radius * Math.PI;
    }
}
