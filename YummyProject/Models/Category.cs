using System.ComponentModel.DataAnnotations;

namespace YummyProject.Models
{
    public class Category
    {

        [Required]
        [MaxLength(60)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<Product>? Products { get; set; }
    }
}
