namespace OnlineStore.Contracts.ProductsDto
{
    /// <summary>
    /// Транспортная модель продукта
    /// </summary>
    public sealed class ProductsDto
    {
        /// <summary>
        /// Id продукта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя продукта
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// Категория продукта
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Колличество продукта.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Список изображений.
        /// </summary>
        public string[] Images { get; set; } = [];
    }
}
