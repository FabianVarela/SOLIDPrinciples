namespace LiskovSubstitution.Abstract
{
    using System;

    public class Ellipse
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public virtual void SetMajorAxis(double majorAxis) => MajorAxis = majorAxis;

        public virtual void SetMinorAxis(double minorAxis) => MinorAxis = minorAxis;

        public virtual double Area() => MajorAxis * MinorAxis * Math.PI;
    }
}
