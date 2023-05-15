using Microsoft.CodeAnalysis.Operations;
using System.ComponentModel.DataAnnotations;

namespace BulkyBooksNewTest.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int id { get; set; }

        public string? Fname { get; set; }

        public string? Lname { get; set; }

        [Required]
        public DateTime createdDateTime { get; set; } = DateTime.Now;
    }
}
