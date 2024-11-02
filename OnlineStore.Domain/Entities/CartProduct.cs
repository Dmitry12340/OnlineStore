namespace OnlineStore.Domain.Entities
{
    public sealed class CartProduct
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Количество.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Идентификатор корзины.
        /// </summary>
        public int CartId {  get; set; }

        /// <summary>
        /// Корзина.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Товар.
        /// </summary>
        public Products Products { get; set; }
    }
}
