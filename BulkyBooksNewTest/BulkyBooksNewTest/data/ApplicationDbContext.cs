using BulkyBooksNewTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooksNewTest.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
