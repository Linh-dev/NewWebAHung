using Microsoft.AspNetCore.Mvc;

namespace eFashionShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
