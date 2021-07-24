using HuntingStoreMongoDb.Server.Repositories;
using MongoDB.Driver;
using System.Threading.Tasks;
using Xunit;

namespace HuntingStoreMongoDb.Test
{
    public class UserRepositoryTests
    {
        private UserRepository _userRepository;

        public UserRepositoryTests()
        {
            var mongoClient = new MongoClient(Constants.MongoDbConnectionUri());
            _userRepository = new UserRepository(mongoClient);
        }

        [Fact]
        public async Task AuthenticateAsyncTest()
        {
            var user = await _userRepository.AuthenticateAsync("Admin", "Secret123$");

            Assert.NotNull(user);
        }
    }
}
