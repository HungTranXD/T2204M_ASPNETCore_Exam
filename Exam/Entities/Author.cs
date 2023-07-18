using System.ComponentModel.DataAnnotations;

namespace Exam.Entities
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
