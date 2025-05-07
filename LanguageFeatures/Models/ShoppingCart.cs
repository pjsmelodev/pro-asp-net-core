namespace LanguageFeatures.Models
{
    public class ShoppingCart
    {
        // O Enumerable e os seus produtos são ambos nullable
        public IEnumerable<Product?>? Products { get; set; }
    }
}
