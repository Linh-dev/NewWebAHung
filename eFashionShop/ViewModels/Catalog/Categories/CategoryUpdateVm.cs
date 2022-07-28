﻿using Microsoft.AspNetCore.Http;

namespace eFashionShop.ViewModels.Catalog.Categories
{
    public class CategoryUpdateVm
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public IFormFile File { get; set; }
    }
}
