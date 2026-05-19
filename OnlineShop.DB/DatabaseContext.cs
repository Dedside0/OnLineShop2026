using Microsoft.EntityFrameworkCore;

namespace OnlineShop.DB
{
    public class DatabaseContext: DbContext
    {
        public DbSet<ProductDB> ProductDBs { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            //Database.Migrate();
            Database.EnsureCreated();
        }

    }
}
