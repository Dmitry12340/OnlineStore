using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Аттрибут товара.
    /// </summary>
    public class ProductAttribute
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
    }
}
