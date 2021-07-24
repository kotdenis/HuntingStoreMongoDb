using HuntingStoreMongoDb.Shared.Models;
using HuntingStoreMongoDb.Shared.State;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Server.Repositories
{
    public class ProductRepository
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMongoCollection<Orders> _ordersCollection;
        private readonly IMongoCollection<CartLine> _cartlineCollection;
        private readonly IMongoClient _mongoClient;
        private List<Product> _productList;

        public ProductRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _productCollection = mongoClient.GetDatabase("huntdb").GetCollection<Product>("product");
            _ordersCollection = mongoClient.GetDatabase("huntdb").GetCollection<Orders>("orders");
            _cartlineCollection = mongoClient.GetDatabase("huntdb").GetCollection<CartLine>("cartline");

        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
        {
            _productList = await _productCollection
                .Find(Builders<Product>.Filter.Empty)
                .ToListAsync();

            if (_productList == null)
                new List<Product>();

            return _productList;
        }

        public async Task CompleteOrderAsync(OrderViewModel ordersVM, CancellationToken cancellationToken = default)
        {
            var order = new Orders()
            {
                Name = ordersVM.Name,
                AddressLine1 = ordersVM.AddressLine1,
                AddressLine2 = ordersVM.AddressLine2 == null ? "" : ordersVM.AddressLine2,
                City = ordersVM.City,
                Country = ordersVM.Country,
                GiftWrap = ordersVM.GiftWrap,
                Shipped = ordersVM.Shipped,
                State = ordersVM.State,
                Zip = ordersVM.Zip
            };
            await _ordersCollection.WithWriteConcern(WriteConcern.W1).InsertOneAsync(order);

            var cartLine = new CartLine();
            var orderEl = await _ordersCollection
                .Find(Builders<Orders>.Filter.Where(x => x.Name == order.Name && x.Zip == order.Zip && x.City == order.City))
                .Sort(Builders<Orders>.Sort.Descending(x => x.Id))
                .FirstOrDefaultAsync();



            var cartLineList = new List<CartLine>();

            foreach (var cartline in ordersVM.CartLineViewModels)
            {
                cartLineList.Add(new CartLine()
                {
                    OrderId = orderEl.Id,
                    ProductId = cartline.ProductId,
                    Quantity = cartline.Quantity
                });
            }

            await _cartlineCollection.InsertManyAsync(cartLineList);
        }
    }
}
