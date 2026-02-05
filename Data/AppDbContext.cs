using Assignment1DHall.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment1DHall.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Lake> Lakes { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
