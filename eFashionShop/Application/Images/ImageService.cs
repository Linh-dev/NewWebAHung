using eFashionShop.Application.CloudinaryService;
using eFashionShop.Data.EF;
using eFashionShop.ViewModels.Catalog.Images;
using eFashionShop.ViewModels.Catalog.ProductImages;
using eFashionShop.ViewModels.Catalog.Products;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFashionShop.Application.Images
{
    public class ImageService : IImageService
    {
        private readonly EShopDbContext _context;
        private readonly IPhotoService _photoService;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";


        public ImageService(EShopDbContext context, IPhotoService photoService)
        {
            _context = context;
            _photoService = photoService;
        }
        public async Task<List<ImageVm>> GetFeaturedImages()
        {
            var query =  _context.ProductImages.Where(x => x.IsDefault == true).AsQueryable();

            var result = await query.Select(x => new ImageVm
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                Caption = x.Caption,
                IsFeatured = x.IsFeatured,
                FileSize = x.FileSize
            }).ToListAsync();

            return result;
        }

        public Task<bool> SetFeaturedImage(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}
