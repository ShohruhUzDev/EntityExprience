using Microsoft.EntityFrameworkCore;

namespace birgabir
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company>Companies  { get; set; }

        public UserContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=onemanyrelationdb; Trusted_Connection=True;");
        }
    }


}
