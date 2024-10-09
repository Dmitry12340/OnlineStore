using OnlineStore.Domain.Entities;

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
        /// Ссылка на изображение товара
        /// </summary>
        public ICollection<ProductImages> Images {  get; set; }
    }
}
