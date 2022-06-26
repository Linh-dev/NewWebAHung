using Microsoft.AspNetCore.Mvc;

namespace eFashionShop.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
