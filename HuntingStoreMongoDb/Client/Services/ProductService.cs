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
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<HttpResponseMessage> CompleteOrderAsync(OrderViewModel order);
    }
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Product>>(new Uri(AppConstant.Uri + "Product/GetProductsAsync"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Product>();
            }
        }

        public async Task<HttpResponseMessage> CompleteOrderAsync(OrderViewModel order)
        {
            try
            {
                Console.WriteLine("Complete order");
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(AppConstant.Uri + "Product/CompleteOrderAsync"),
                    Method = HttpMethod.Post,
                    Content = JsonContent.Create(order)
                };
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await _httpClient.SendAsync(request);

                return response;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
