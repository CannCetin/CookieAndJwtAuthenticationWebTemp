using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Entites
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
