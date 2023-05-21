using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace YummyProject.Models
{
    public class Product
    {
        [Required]
        [MaxLength(60)]
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
