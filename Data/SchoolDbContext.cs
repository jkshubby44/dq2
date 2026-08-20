using Microsoft.EntityFrameworkCore;
using program.Models;

namespace program
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        
    }
}