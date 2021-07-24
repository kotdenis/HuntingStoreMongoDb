using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace HuntingStoreMongoDb.Server.Repositories
{
    public static class RepositoryExtensions
    {
        public static void RegisterMongoDbRepositories(this IServiceCollection servicesBuilder)
        {
            servicesBuilder.AddSingleton<IMongoClient, MongoClient>(s =>
            {
                var uri = s.GetRequiredService<IConfiguration>()["MongoUri"];
                return new MongoClient(uri);
            });

            servicesBuilder.AddScoped<ProductRepository>();
            servicesBuilder.AddScoped<AdminRepository>();
            servicesBuilder.AddScoped<UserRepository>();
        }
    }
}
