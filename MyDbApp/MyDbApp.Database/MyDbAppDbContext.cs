using Microsoft.EntityFrameworkCore;
using MyDbApp.Domain;

namespace MyDbApp.Database
{
    public class MyDbAppDbContext : DbContext
    {
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<GymEntity> GymAccessories { get; set; }
        public DbSet<RunEntity> RunAccessories { get; set; }
        public DbSet<SwimEntity> SwimAccessories { get; set; }
        public DbSet<WearEntity> Wears { get; set; }
        public MyDbAppDbContext(DbContextOptions<MyDbAppDbContext> options) : base(options)
        {

        }
    }
}
