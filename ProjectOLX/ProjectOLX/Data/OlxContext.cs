using Microsoft.EntityFrameworkCore;
using ProjectOLX.Data.Entities;

namespace ProjectOLX.Data
{
    public class OlxContext : DbContext
    {
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ep-lively-snowflake-a2h0k1on-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_NHJoc4p2gzWA");
        }
    }
}
