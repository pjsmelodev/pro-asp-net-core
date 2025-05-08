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
            var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
            return View(names);
        }
    }
}