//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product?[] products = Product.GetProducts();

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
            return View(new string[] { products[0]!.Name });
        }
    }
}
