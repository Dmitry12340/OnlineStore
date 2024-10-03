namespace OnlineStore.Contracts.ProductsDto
{
    /// <summary>
    /// Транспортная модель продукта
    /// </summary>
    public sealed class ProductsDto
    {
        /// <summary>
        /// Имя продукта
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// Категория продукта
        /// </summary>
        public string Category { get; set; }
    }
}
