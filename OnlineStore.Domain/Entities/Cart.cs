namespace OnlineStore.Domain.Entities
{
    public sealed class Cart
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Дата создания корзины.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата обновления корзины.
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Дата оформления корзины.
        /// </summary>
        public DateTime? Closed { get; set; }

        /// <summary>
        /// Пользователь.
        /// </summary>
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Товары корзины.
        /// </summary>
        public ICollection<CartProduct> Products { get; set; }
    }
}
