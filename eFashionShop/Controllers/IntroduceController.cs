using Microsoft.AspNetCore.Mvc;

namespace eFashionShop.Controllers
{
    public class IntroduceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
