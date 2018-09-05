namespace InterfaceSegregation
{
    using InterfaceSegregation.Class;

    public class ISPProducts
    {
        public string GetPants(int id, int weight, int stock, int inseam, int size)
        {
            Jean jean = new Jean
            {
                ID = id,
                Weight = weight,
                Stock = stock,
                Inseam = inseam,
                WaistSize = size
            };

            return jean.GetFeatures();
        }

        public string GetHat(int id, int weight, int stock, int size)
        {
            Cap cap = new Cap
            {
                ID = id,
                Weight = weight,
                Stock = stock,
                HatSize = size
            };

            return cap.GetFeatures();
        }
    }
}
