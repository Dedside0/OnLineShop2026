using Microsoft.EntityFrameworkCore;

namespace OnlineShopp.DB
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
