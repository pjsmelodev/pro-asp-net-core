namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        // this -> faz com que TotalPrices seja um extension method
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            if (cartParam.Products != null)
            {
                foreach (Product? prod in cartParam.Products)
                {
                    total += prod?.Price ?? 0;
                }
            }
            return total;
        }
    }
}