namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Атрибут товара
    /// </summary>
    public sealed class Attribute
    {
        /// <summary>
        /// Идентифекатор
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}
