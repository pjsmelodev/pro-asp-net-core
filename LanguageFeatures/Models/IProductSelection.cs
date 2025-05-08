namespace LanguageFeatures.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product>? Products { get; }

        // Default Definition
        // desta forma não preciso alterar todas as classes que usam este interface de acada vez que o alterar
        IEnumerable<string>? Names => Products?.Select(p => p.Name);
    }
}
