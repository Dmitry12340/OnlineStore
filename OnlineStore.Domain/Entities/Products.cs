namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Products
    {
        public object name;

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Признак удаления товара.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Категория продукта.
        /// </summary>
        public string Category {  get; set; }

        /// <summary>
        /// Описание продукта
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Колличество продукта.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Изображения товара.
        /// </summary>
        public List<ProductImages> Images { get; set; } = [];
    }
}
