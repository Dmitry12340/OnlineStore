using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Атрибут товара
    /// </summary>
    [Table("Attribute")]
    public sealed class Attribute
    {
        /// <summary>
        /// Идентифекатор
        /// </summary>
        [Key]
        int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
    }
}
