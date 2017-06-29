using Microsoft.EntityFrameworkCore;

namespace StoreSpa.DataAccess {
    public class ProductContext : DbContext {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite(@"Data Source=..\..\..\..\..\db\products.db");
        }
    }
}
