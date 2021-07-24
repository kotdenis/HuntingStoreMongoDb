using HuntingStoreMongoDb.Shared.Models;
using System.Collections.Generic;

namespace HuntingStoreMongoDb.Test.Helpers
{
    public class AdminHelper
    {
        public List<CartLine> GetCartLines()
        {
            return new List<CartLine>()
            {
                new CartLine()
                {
                    Id = "1",
                    OrderId = "1",
                    ProductId = "1",
                    Quantity = 1
                },
                new CartLine()
                {
                    Id = "2",
                    OrderId = "1",
                    ProductId = "1",
                    Quantity = 2
                },
                new CartLine()
                {
                    Id = "3",
                    OrderId = "2",
                    ProductId = "3",
                    Quantity = 1
                },
                new CartLine()
                {
                    Id = "4",
                    OrderId = "1",
                    ProductId = "2",
                    Quantity = 1
                }
            };
        }

        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Category = "",
                    Description = "",
                    Id = "1",
                    Name = "Name1",
                    Price = 100
                },
                new Product()
                {
                    Category = "",
                    Description = "",
                    Id = "2",
                    Name = "Name2",
                    Price = 100
                },
                new Product()
                {
                    Category = "",
                    Description = "",
                    Id = "3",
                    Name = "Name3",
                    Price = 100
                },
                new Product()
                {
                    Category = "",
                    Description = "",
                    Id = "4",
                    Name = "Name4",
                    Price = 100
                }
            };
        }

        public Orders GetOrders()
        {
            return new Orders()
            {
                AddressLine1 = "",
                AddressLine2 = "",
                City = "",
                Country = "",
                GiftWrap = false,
                Id = "1",
                Name = "",
                Shipped = false,
                State = "",
                Zip = ""
            };
        }
    }
}
