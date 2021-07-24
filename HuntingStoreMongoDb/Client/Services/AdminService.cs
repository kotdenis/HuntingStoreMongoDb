using HuntingStoreMongoDb.Shared.Constants;
using HuntingStoreMongoDb.Shared.Models;
using HuntingStoreMongoDb.Shared.State;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Client.Services
{
    public interface IAdminService
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<OrderViewModel>> GetAllOrdersAsync();
        Task<HttpResponseMessage> UpdateOrderAsync(OrderViewModel orders);
        Task<HttpResponseMessage> EditProductAsync(Product product);
        Task<HttpResponseMessage> CreateProductAsync(Product product);
        Task<HttpResponseMessage> DeleteProductAsync(Product product);
    }
    public class AdminService : IAdminService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public AdminService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Product>>(new Uri(AppConstant.Uri + "Admin/GetProductsAsync"));
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }

        public async Task<List<OrderViewModel>> GetAllOrdersAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<OrderViewModel>>(new Uri(AppConstant.Uri + "Admin/GetOrdersAsync"));
            }
            catch (Exception)
            {
                return new List<OrderViewModel>();
            }
        }

        public async Task<HttpResponseMessage> UpdateOrderAsync(OrderViewModel orders)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/UpdateOrdersAsync"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(orders)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public async Task<HttpResponseMessage> EditProductAsync(Product product)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/EditProductAsync"),
                    Method = HttpMethod.Put,
                    Content = JsonContent.Create(product)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public async Task<HttpResponseMessage> CreateProductAsync(Product product)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/CreateProductAsync"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(product)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public async Task<HttpResponseMessage> DeleteProductAsync(Product product)
        {
            try
            {
                var token = await _localStorage.GetItem<string>(AppConstant.Token);
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Admin/DeleteProductAsync"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(product)
                };
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }


    }
}
