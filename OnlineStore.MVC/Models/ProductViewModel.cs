using System.ComponentModel.DataAnnotations;

namespace OnlineStore.MVC.Models
{
    public class ProductViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
