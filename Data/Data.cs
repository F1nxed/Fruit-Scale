using Microsoft.EntityFrameworkCore;
using Fruit_Scale.Models;

namespace Fruit_Scale.Data
{
    internal class AppDb : DbContext
    {
        public DbSet<Products> Products => Set<Products>();
        public DbSet<Sales> Sales => Set<Sales>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = @"D:\C#\Fruit-Scale\Data\data.db";
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }
    }

}
