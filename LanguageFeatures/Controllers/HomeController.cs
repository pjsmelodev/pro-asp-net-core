namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    return View(Product.GetProducts().Select(p => p?.Name));
        //}

        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));
        // lambda notation não carece de return (implícito)

        public ViewResult Index()
        {
            // var permite instanciar variáveis locais e inferir o seu tipo
            //var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            //return View(names);

            var products = new[]
            {
                new { Name = "Kayak", Price = 275M},
                new { Name = "Lifejacket", Price = 48.95M},
                new { Name = "Soccer ball", Price = 19.50M},
                new { Name = "Corner flag", Price = 39.95M}
            };

            return View(products.Select(p => p.Name));
        }
    }
}