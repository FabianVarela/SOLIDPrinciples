namespace LiskovSubstitution.Abstract
{
    public class Rectangle
    {
        public int Length { get; private set; }
        public int Breadth { get; private set; }

        public virtual void SetLength(int length) => Length = length;

        public virtual void SetBreadth(int breadth) => Breadth = breadth;

        public int GetArea() => Length * Breadth;
    }
}
