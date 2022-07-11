using eFashionShop.Application.Images;
using eFashionShop.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eFashionShop.Controllers
{
    public class IntroduceController : Controller
    {
        private readonly IImageService _imageService;

        public IntroduceController(IImageService imageService)
        {
            _imageService = imageService;
        }
        public async Task<IActionResult> Index()
        {
            var FeaturedImages = await _imageService.GetFeaturedImages(SystemConstants.ProductSettings.NumberOfFeaturedImages);
            return View(FeaturedImages);
        }
    }
}
