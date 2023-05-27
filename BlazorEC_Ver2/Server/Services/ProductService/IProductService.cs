namespace BlazorEC_Ver2.Server.Services.ProductService
{
    public interface IProductService 
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
