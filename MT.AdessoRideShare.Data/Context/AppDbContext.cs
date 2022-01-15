using Microsoft.EntityFrameworkCore;
using MT.AdessoRideShare.Core.Entity;

namespace MT.AdessoRideShare.Data.Context
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<TravelPlan> TravelPlans { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
