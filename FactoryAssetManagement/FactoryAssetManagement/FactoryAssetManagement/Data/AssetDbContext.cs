using Microsoft.EntityFrameworkCore;

namespace FactoryAssetManagement.Data
{
    public class AssetDbContext :DbContext
    {
        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options) { }
        public DbSet<Asset> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}
