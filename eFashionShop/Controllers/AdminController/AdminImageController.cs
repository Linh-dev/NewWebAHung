using Microsoft.AspNetCore.Mvc;

namespace eFashionShop.Controllers.AdminController
{
    public class AdminImageController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
