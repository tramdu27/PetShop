using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CategoryServies
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set ; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
           {
               new Category {Id = 1, Name = "Cats Treats", Url="cats", Icon = "list-rich"},
               new Category {Id = 2, Name = "Dogs Treats", Url="dogs", Icon = "list-rich"},
               new Category {Id = 3, Name = "Pa te", Url="pa te", Icon = "list-rich"}
           };
        }
    }
}
