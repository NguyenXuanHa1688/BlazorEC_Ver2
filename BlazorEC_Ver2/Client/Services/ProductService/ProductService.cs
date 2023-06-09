﻿using BlazorEC_Ver2.Shared;
using System.Net.Http.Json;

namespace BlazorEC_Ver2.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Loading Product ...";

        public event Action ProductsChange;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") : await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
            ProductsChange.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestion(string searchText)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestion/{searchText}");
            return result.Data;
        }

        public async Task SearchProduct(string searchText)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/search/{searchText}");
            if(result != null && result.Data != null)
            {
                Products = result.Data;
            }
            if(Products.Count == 0)
            {
                Message = "No Product found";
            }
            ProductsChange?.Invoke();
        }
    }
}
