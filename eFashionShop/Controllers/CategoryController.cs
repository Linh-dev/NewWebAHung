using Microsoft.AspNetCore.Mvc;

namespace eFashionShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
