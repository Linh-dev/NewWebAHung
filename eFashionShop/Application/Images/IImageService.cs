using eFashionShop.ViewModels.Catalog.Images;
using eFashionShop.ViewModels.Catalog.ProductImages;
using eFashionShop.ViewModels.Catalog.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eFashionShop.Application.Images
{
    public interface IImageService
    {
        Task<List<ImageVm>> GetFeaturedImages();
        Task<bool> SetFeaturedImage(int id);
    }
}
