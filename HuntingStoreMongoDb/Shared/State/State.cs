using HuntingStoreMongoDb.Shared.Models;
using System.Collections.Generic;

namespace HuntingStoreMongoDb.Shared.State
{
    public class State
    {
        public List<CartLineViewModel> CartLineViewModels { get; set; } = new List<CartLineViewModel>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Product> AdminProducts { get; set; } = new List<Product>();
        public List<OrderViewModel> AllOrders { get; set; } = new List<OrderViewModel>();
    }
}
