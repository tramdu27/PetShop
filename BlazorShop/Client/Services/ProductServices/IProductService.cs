using BlazorShop.Shared;

namespace BlazorShop.Client.Services.ProductServices
{
    public interface IProductService
    {
       List<Product> Products { get; set; }
        void LoadProducts();
    }
}
