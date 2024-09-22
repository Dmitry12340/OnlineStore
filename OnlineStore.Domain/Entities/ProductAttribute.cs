using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Аттрибут товара.
    /// </summary>
    [Table("attributes")]
    public class ProductAttribute
    {
        public object name;

        /// <summary>
        /// Идентификатор.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        [Column("name")]
        public string Name { get; set; } = default!;
    }
}
