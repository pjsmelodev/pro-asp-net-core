﻿namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M},
                new { Name = "Lifejacket", Price = 48.95M},
                new { Name = "Soccer ball", Price = 19.50M},
                new { Name = "Corner flag", Price = 39.95M}
            };
            //return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price:C}"));

            // nameof é um método usado para obter o nome de uma variável, propriedade ou tipo como uma string.
            return View(products.Select(p =>
                $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}