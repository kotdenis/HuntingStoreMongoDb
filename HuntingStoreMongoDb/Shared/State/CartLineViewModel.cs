namespace HuntingStoreMongoDb.Shared.State
{
    public class CartLineViewModel
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
