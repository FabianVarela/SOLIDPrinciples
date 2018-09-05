namespace LiskovSubstitution.Class
{
    using LiskovSubstitution.Abstract;

    public class Square : Rectangle
    {
        public override void SetBreadth(int breadth)
        {
            base.SetBreadth(breadth);
            base.SetLength(breadth);
        }

        public override void SetLength(int length)
        {
            base.SetLength(length);
            base.SetBreadth(length);
        }
    }
}
