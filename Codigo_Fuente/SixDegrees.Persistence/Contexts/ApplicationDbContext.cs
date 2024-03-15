using Microsoft.EntityFrameworkCore;
using SixDegrees.Entities;

namespace SixDegrees.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Usuarios { get; set; }
    }
}
