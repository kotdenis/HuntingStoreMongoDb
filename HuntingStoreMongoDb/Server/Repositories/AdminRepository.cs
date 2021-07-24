using HuntingStoreMongoDb.Shared.Models;
using HuntingStoreMongoDb.Shared.State;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Server.Repositories
{
    public class AdminRepository
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMongoCollection<Orders> _orderCollection;
        private readonly IMongoCollection<CartLine> _cartlineCollection;
        private readonly IMongoClient _mongoClient;
        private List<Product> _productList;
        public AdminRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _productCollection = mongoClient.GetDatabase("huntdb").GetCollection<Product>("product");
            _orderCollection = mongoClient.GetDatabase("huntdb").GetCollection<Orders>("orders");
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

        public async Task<IReadOnlyList<OrderViewModel>> GetOrdersAsync(CancellationToken cancellationToken = default)
        {
            var orderList = await _orderCollection
                .Find(Builders<Orders>.Filter.Empty)
                .ToListAsync();
            var cartlineList = await _cartlineCollection
                .Find(Builders<CartLine>.Filter.Empty)
                .ToListAsync();
            _productList = await _productCollection
                .Find(Builders<Product>.Filter.Empty)
                .ToListAsync();

            if (orderList == null)
                return null;

            List<OrderViewModel> orderViewModels = new List<OrderViewModel>();
            List<CartLineViewModel> cartlineViewModel;

            foreach (var order in orderList)
            {
                cartlineViewModel = await GetCartLineViewModels(cartlineList, _productList, order);

                orderViewModels.Add(new OrderViewModel()
                {
                    AddressLine1 = order.AddressLine1,
                    AddressLine2 = order.AddressLine2,
                    City = order.City,
                    Country = order.Country,
                    GiftWrap = order.GiftWrap,
                    Id = order.Id,
                    Name = order.Name,
                    Shipped = order.Shipped,
                    State = order.State,
                    Zip = order.Zip,
                    CartLineViewModels = cartlineViewModel
                });

            }

            return orderViewModels;
        }

        public async Task UpdateOrderAsync(OrderViewModel orderViewModel)
        {

            await _orderCollection.UpdateOneAsync(Builders<Orders>.Filter.Eq(x => x.Id, orderViewModel.Id), Builders<Orders>
                .Update.Set("shipped", orderViewModel.Shipped));
        }

        public async Task EditProductAsync(Product product)
        {
            await _productCollection.UpdateOneAsync(Builders<Product>.Filter.Eq(x => x.Id, product.Id), Builders<Product>.Update
                .Set(x => x.Id, product.Id)
                .Set(x => x.Name, product.Name)
                .Set(x => x.Price, product.Price)
                .Set(x => x.Category, product.Category)
                .Set(x => x.Description, product.Description));
        }

        public async Task CreateProductAsync(Product product)
        {
            if (product.Price <= 0)
                throw new ArgumentException("The price is negative");
            await _productCollection.WithWriteConcern(WriteConcern.W1).InsertOneAsync(product);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(Builders<Product>.Filter.Where(x => x.Id == id));
        }

        private async Task<List<CartLineViewModel>> GetCartLineViewModels(List<CartLine> cartLines, List<Product> products, Orders order)
        {
            List<CartLineViewModel> cartlineViewModel = new List<CartLineViewModel>();
            foreach (var c in cartLines.Where(x => x.OrderId == order.Id))
            {
                var product = products.Where(x => x.Id == c.ProductId).FirstOrDefault();
                cartlineViewModel.Add(new CartLineViewModel()
                {
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = c.Quantity,
                    ProductId = product.Id
                });
            }

            await Task.CompletedTask;

            return cartlineViewModel;
        }
    }
}
