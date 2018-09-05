namespace LiskovSubstitution.Class
{
    using LiskovSubstitution.Abstract;

    public class Circle : Ellipse
    {
        public override double Area() => base.Area();

        public override void SetMajorAxis(double majorAxis)
        {
            base.SetMajorAxis(majorAxis);
            this.MinorAxis = majorAxis;
        }

        public override void SetMinorAxis(double minorAxis)
        {
            base.SetMinorAxis(minorAxis);
            this.MajorAxis = minorAxis;
        }
    }
}
