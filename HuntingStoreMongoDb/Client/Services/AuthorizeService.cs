using HuntingStoreMongoDb.Shared.IdentityModels;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Client.Services
{
    public interface IAuthorizeService
    {
        Task<HttpResponseMessage> Login(LoginModel loginModel);
        Task<CurrentUser> GetCurrentUser();
        Task Logout();
    }
    public class AuthorizeService : IAuthorizeService
    {
        private readonly HttpClient _httpClient;
        public AuthorizeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> Login(LoginModel loginModel)
        {
            var result = await _httpClient.PostAsJsonAsync("Account/LoginAsync", loginModel);
            if (result.StatusCode == HttpStatusCode.BadRequest || result.StatusCode == HttpStatusCode.InternalServerError)
                throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();

            return result;
        }

        public async Task<CurrentUser> GetCurrentUser()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<CurrentUser>("Account/GetCurrentUser");
            }
            catch (Exception ex)
            {
                return new CurrentUser();
            }
        }

        public async Task Logout()
        {
            await _httpClient.PostAsJsonAsync("Account/Logout", new CurrentUser());
        }
    }
}
