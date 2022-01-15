using Microsoft.EntityFrameworkCore;
using MT.AdessoRideShare.Core.Entity;
using MT.AdessoRideShare.Data.Seeds;

namespace MT.AdessoRideShare.Data.Context
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<TravelPlan> TravelPlans { get; set; }

        public DbSet<UserTravelPlan> UserTravelPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new TravelPlanSeed(new int[] { 1, 2 }));
        }
    }
}
