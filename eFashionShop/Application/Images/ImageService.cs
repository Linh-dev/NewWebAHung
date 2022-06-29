using eFashionShop.Application.CloudinaryService;
using eFashionShop.Constants;
using eFashionShop.Data.EF;
using eFashionShop.Data.Entities;
using eFashionShop.ViewModels.Catalog.Images;
using eFashionShop.ViewModels.Catalog.ProductImages;
using eFashionShop.ViewModels.Catalog.Products;
using eFashionShop.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFashionShop.Application.Images
{
    public class ImageService : IImageService
    {
        private readonly EShopDbContext _context;
        private readonly IPhotoService _photoServiece;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";


        public ImageService(EShopDbContext context, IPhotoService photoServiece)
        {
            _context = context;
            _photoServiece = photoServiece;
        }
        public async Task<List<ImageVm>> GetFeaturedImages(int count)
        {
            var query = _context.ProductImages.OrderBy(x => x.SortOrder).Where(x => x.IsFeatured == true).AsQueryable();

            if(count > 0)
            {
                query.Take(count);
            }
            var result = await query.Select(x => new ImageVm
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                Caption = x.Caption,
                IsFeatured = x.IsFeatured,
            }).ToListAsync();

            return result;
        }

        public async Task<bool> SetFeaturedImage(int id)
        {
            var query = await _context.ProductImages.OrderBy(x => x.SortOrder).Where(x => x.IsFeatured == true).ToListAsync();
            var image = await _context.ProductImages.FirstOrDefaultAsync(x => x.Id == id);
            image.IsFeatured = true;
            image.SortOrder = 0;
            _context.ProductImages.Update(image);
            for(int i = 0; i < query.Count; i++)
            {
                if(i >= SystemConstants.ProductSettings.NumberOfFeaturedImages)
                {
                    query[i].IsFeatured = false;
                    query[i].SortOrder = -1;
                }
                else
                {
                    query[i].SortOrder += 1;
                }
                _context.ProductImages.Update(query[i]);
            }
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> AddImage(ImageCreateRedVm red)
        {
            var resultImage = await _photoServiece.AddPhotoAsync(red.File);
            if (resultImage == null) return false;
            var image = new ProductImage
            {
                PublicId = resultImage.PublicId,
                ProductId = 0,
                ImagePath = resultImage.SecureUrl.AbsoluteUri,
                Caption = red.Caption,
                IsDefault = null,
                IsOutstanding = null,
                DateCreated = System.DateTime.Now,
                SortOrder = null,
                FileSize = null,
                IsFeatured = false
            };
            _context.ProductImages.Add(image);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteImage(int id)
        {
            var image = await _context.ProductImages.FirstOrDefaultAsync(x => x.Id == id);
            if (image == null) return false;
            await _photoServiece.DeletePhotoAsync(image.PublicId);

            _context.ProductImages.Remove(image);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<PagedResult<ImageVm>> GetAll(GetManageImagePagingRequest request)
        {
            var data = new List<ImageVm>();
            var query = _context.ProductImages.OrderBy(x => x.IsFeatured);
            data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ImageVm()
                {
                    Id = x.Id,
                    ImagePath = x.ImagePath,
                    Caption = x.Caption,
                    IsFeatured = x.IsFeatured
                }).ToListAsync();
            var totalRecords = await query.CountAsync();
            var result = new PagedResult<ImageVm>()
            {
                TotalRecords = totalRecords,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return result;
        }
    }
}
