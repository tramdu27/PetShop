using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CategoryServies
{
    public interface ICategoryService
    {
        public List<Category>  Categories { get; set; }
        void LoadCategories();
    }
}
