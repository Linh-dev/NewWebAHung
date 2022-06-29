using eFashionShop.Data.Enums;

namespace eFashionShop.ViewModels.Catalog.Categories
{
    public class CategoryCreateVm
    {
        public string Name { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
    }
}
