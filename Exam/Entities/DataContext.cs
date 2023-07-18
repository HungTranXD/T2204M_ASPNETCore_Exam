using Microsoft.EntityFrameworkCore;

namespace Exam.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
        
    }
}
