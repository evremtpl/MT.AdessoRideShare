using Microsoft.EntityFrameworkCore;
using MT.AdessoRideShare.Core.Entity;

namespace MT.AdessoRideShare.Data.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Persons { get; set; }

        public DbSet<TravelPlan> ContactInfos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
