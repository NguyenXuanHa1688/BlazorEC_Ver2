using BlazorEC_Ver2.Shared;

namespace BlazorEC_Ver2.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChange;
        List<Product> Products { get; set; }
        string Message { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
        Task SearchProduct(string searchText);
        Task<List<string>> GetProductSearchSuggestion(string searchText);
    }
}
