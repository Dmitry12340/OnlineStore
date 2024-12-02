using System.ComponentModel.DataAnnotations;

namespace OnlineStore.MVC.Models
{
    public class RoleViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
