namespace InterfaceSegregation.Interface
{
    public interface IProduct
    {
        int ID { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }

        string GetFeatures();
    }
}
