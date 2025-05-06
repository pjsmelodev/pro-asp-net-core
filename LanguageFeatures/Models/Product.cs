namespace LanguageFeatures.Models
{
    public class Product
    {

        public string Name { get; set; } = string.Empty;

        public decimal? Price { get; set; }

        public static Product?[] GetProducts()
        {
            Product kayak = new Product()
            {
                Name = "Kayak",
                Price = 275M
            };

            Product lifejack = new Product()
            {
                Name = "Lifejack",
                Price = 48.95M
            };

            return new Product?[] { kayak, lifejack, null };
        }
    }
}
