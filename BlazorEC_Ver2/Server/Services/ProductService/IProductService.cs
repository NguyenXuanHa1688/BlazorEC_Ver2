﻿namespace BlazorEC_Ver2.Server.Services.ProductService
{
    public interface IProductService 
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductByCategory(string categoryUrl);
        Task<ServiceResponse<List<Product>>> SearchProduct(string searchText);
        Task<ServiceResponse<List<string>>> GetProductSearchSuggestion(string searchText);
    }
}
