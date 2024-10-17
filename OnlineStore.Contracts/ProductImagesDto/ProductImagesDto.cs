namespace OnlineStore.Contracts.ProductImageDto
{
    public sealed class ProductImagesDto
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public int ProductId { get; set; }
    }
}
