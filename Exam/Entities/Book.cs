using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Range(0, Double.MaxValue)]
        public double Price { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
