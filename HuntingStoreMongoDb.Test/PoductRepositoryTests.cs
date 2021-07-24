using HuntingStoreMongoDb.Server.Repositories;
using MongoDB.Driver;
using System.Threading.Tasks;
using Xunit;

namespace HuntingStoreMongoDb.Test
{
    public class PoductRepositoryTests
    {
        private ProductRepository _productRepository;

        public PoductRepositoryTests()
        {
            var mongoClient = new MongoClient(Constants.MongoDbConnectionUri());
            _productRepository = new ProductRepository(mongoClient);
        }

        [Fact]
        public async Task GetProductsTest()
        {
            var result = await _productRepository.GetProductsAsync();

            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
    }
}
