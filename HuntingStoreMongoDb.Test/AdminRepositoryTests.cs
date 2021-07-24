using HuntingStoreMongoDb.Server.Repositories;
using HuntingStoreMongoDb.Shared.Models;
using HuntingStoreMongoDb.Test.Helpers;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;
using Xunit;

namespace HuntingStoreMongoDb.Test
{
    public class AdminRepositoryTests
    {

        private AdminRepository _adminRepository;
        public AdminRepositoryTests()
        {
            var mongoClient = new MongoClient(Constants.MongoDbConnectionUri());
            _adminRepository = new AdminRepository(mongoClient);

        }

        [Fact]
        public async Task GetOrdersTest()
        {
            var orders = await _adminRepository.GetOrdersAsync();

            Assert.NotNull(orders);
        }

        [Fact]
        //make GetCartLineViewModels public before testing
        public async Task GetCartLineViewModelsTest()
        {
            AdminHelper helper = new AdminHelper();

            //var result = await _adminRepository.GetCartLineViewModels(helper.GetCartLines(), helper.GetProducts(), helper.GetOrders());

            //var products = result.Where(x => x.Name == "Name1").ToList();

            //Assert.Equal(3, result.Count);
            //Assert.Equal(2, products.Count);
        }

        [Fact]
        public async Task CreateProductWithNegativePrice()
        {
            var product = new Product
            {
                Price = -10000
            };

            await Assert.ThrowsAnyAsync<ArgumentException>(async () => await _adminRepository.CreateProductAsync(product));

        }

        [Fact]
        public async Task EditProductAsyncTest()
        {
            var product = new Product
            {
                Id = "no Id"
            };

            await Assert.ThrowsAnyAsync<FormatException>(async () => await _adminRepository.EditProductAsync(product));
        }
    }
}
