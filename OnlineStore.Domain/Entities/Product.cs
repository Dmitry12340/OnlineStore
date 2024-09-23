using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Entities
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product
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
        /// Изображения товара.
        /// </summary>
        //public ICollection<ProductImage> Images { get; set; } = [];
    }
}
