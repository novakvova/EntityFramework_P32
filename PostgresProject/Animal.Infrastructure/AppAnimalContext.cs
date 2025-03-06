using Animal.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Animal.Infrastructure
{
    public class AppAnimalContext : DbContext
    {
        public DbSet<Specie> Species { get; set; }

        public DbSet<AnimalEntity> Animals { get; set; }

        public AppAnimalContext() //Якщо не передаємо налашування
        {
            
        }

        //Якщо задано налаштування
        public AppAnimalContext(DbContextOptions<AppAnimalContext> options)
            : base(options) { }

        //Налаштування по замовчуванні
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Server=localhost;Database=AnimalDb;User Id=postgres;Password=123456;");
            optionsBuilder.UseNpgsql("Host=ep-damp-cell-a2taj2ik-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_TnC7QlaA3bWx");
        }
    }
}
