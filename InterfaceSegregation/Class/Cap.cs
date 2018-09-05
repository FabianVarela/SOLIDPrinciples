namespace InterfaceSegregation.Class
{
    using InterfaceSegregation.Interface;

    public class Cap : IProduct, IHat
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }

        public int HatSize { get; set; }

        public string GetFeatures()
        {
            string product = string.Empty;

            product += "Product name: Cap\n";
            product += $"Id: {ID}\n";
            product += $"Weight: {Weight}\n";
            product += $"Stock: {Stock}\n";
            product += $"Size: {HatSize}";

            return product;
        }
    }
}
