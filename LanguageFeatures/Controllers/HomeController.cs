//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product? p)
        {
            return (p?.Price ?? 0) >= 20;
        }

        public ViewResult Index()
        {
            //Product?[] products = Product.GetProducts();

            //Product? p = products[0];
            //string val;
            //if (p != null)
            //{
            //    val = p.Name;
            //}
            //else
            //{
            //    val = "No value";
            //}
            //return View(new string[] { val });

            //string? val = products[0]?.Name;
            //if (val != null)
            //{
            //    return View(new string[] { val });
            //}
            //return View(new string[] { "No value" });

            //return View(new string[] { products[0]?.Name ?? "No value" });
            //return View(new string[]
            //{
            //    $"Name: {products[0]?.Name}, Price: {products[0]?.Price}"
            //});

            //string[] names = new string[3];
            //names[0] = "Bob";
            //names[1] = "Joe";
            //names[2] = "Alice";
            //return View("Index", names);

            //return View("Index", new string[] { "Bob", "Joe", "Alice" });

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //Dictionary<string, Product> products = new()
            //{
            //    //{ "Kayak", new Product
            //    //    { Name = "Kayak", Price = 275M }
            //    //},
            //    //{ "Lifejack", new Product
            //    //{ Name = "Lifejack", Price = 48.95M }
            //    //}
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejack"] = new Product { Name = "Lifejack", Price = 48.95M }
            //};

            //return View("Index", products.Keys);

            //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    //if (data[i] is decimal d)
            //    //{
            //    //    total += d;
            //    //}

            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            //case decimal decimalValueMoreThan50 when decimalValueMoreThan50 > 50:
            //            total += decimalValue;
            //            //total += decimalValueMoreThan50;
            //            break;
            //        case int intValue:
            //            //case int intValueMoreThan10 when intValueMoreThan10 > 10:
            //            total += intValue;
            //            //total += intValueMoreThan10;
            //            break;
            //    }
            //}

            //return View("Index", new string[] { $"Total: {total:C2}" });

            // Aplicação do extension method
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray =
            //{
            //    new Product { Name = "Kayak", Price = 275M },
            //    new Product { Name = "Lifejack", Price = 48.95M }
            //};

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();

            //return View("Index", new string[] { $"Cart Total: {cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });

            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejack", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            Func<Product?, bool> nameFilter = delegate (Product? prod)
            {
                return prod?.Name[0] == 'S';
            };

            // só os products com preço >= 20 é que são passados para o método de soma
            //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            //return View("Index", new string[] { $"Array Total: {arrayTotal}" });

            //decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
        }
    }
}
