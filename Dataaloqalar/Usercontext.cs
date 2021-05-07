using Microsoft.EntityFrameworkCore;

namespace Dataaloqalar
{
    public class Usercontext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }

        public Usercontext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=relationdb; Trusted_Connection=True;");
        }
    }


}
