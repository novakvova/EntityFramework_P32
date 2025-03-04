using _1.SimpleSQLite.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1.SimpleSQLite.Data
{
    public class MyApplicationContext : DbContext
    {
        /// <summary>
        /// У БД буде табличка tbl_categories
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bober.girl");
        }
    }
}
