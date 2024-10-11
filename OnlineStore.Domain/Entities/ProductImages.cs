namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Изображение товара
    /// </summary>
    public class ProductImages
    {
        /// <summary>
        /// Id картинки продукта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ссылка на картинку
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Id продукта к которому относится картинка
        /// </summary>
        public int ProductId {  get; set; }

        /// <summary>
        /// Навигационное свойство для связи с продуктом
        /// </summary>
        public Products Products { get; set; }
    }
}