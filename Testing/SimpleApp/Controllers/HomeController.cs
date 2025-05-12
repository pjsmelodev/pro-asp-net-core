using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using static SimpleApp.Models.Product;
namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IDataSource dataSource = new ProductDataSource();
        public ViewResult Index()
        {
            return View(dataSource.Products);
        }
    }
}