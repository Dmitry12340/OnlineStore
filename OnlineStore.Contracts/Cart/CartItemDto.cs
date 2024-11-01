namespace OnlineStore.Contracts.Cart
{
    public sealed class CartItemDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price {  get; set; }
        public int Quantity {  get; set; }
    }
}
