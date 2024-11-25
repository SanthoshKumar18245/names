using Microsoft.EntityFrameworkCore;

namespace NameStorageApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<NameEntry> Names { get; set; }
    }

    public class NameEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
