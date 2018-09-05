namespace InterfaceSegregation.Class
{
    using InterfaceSegregation.Interface;

    public class Jean : IProduct, IPants
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }

        public int Inseam { get; set; }
        public int WaistSize { get; set; }

        public string GetFeatures()
        {
            string product = string.Empty;

            product += "Product name: Jean\n";
            product += $"Id: {ID}\n";
            product += $"Weight: {Weight}\n";
            product += $"Stock: {Stock}\n";
            product += $"Inseam: {Inseam}\n";
            product += $"Size: {WaistSize}";

            return product;
        }
    }
}
