using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MT.AdessoRideShare.Core.Entity;

namespace MT.AdessoRideShare.Data.Configurations
{
    class TravelPlanConfiguration : IEntityTypeConfiguration<TravelPlan>
    {
        public void Configure(EntityTypeBuilder<TravelPlan> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ToWhere).IsRequired().HasMaxLength(200);
            builder.Property(x => x.FromWhere).IsRequired().HasMaxLength(200);
            builder.Property(x => x.TravelTime).IsRequired();
            builder.Property(x => x.Explanation).IsRequired().HasMaxLength(300);
            builder.Property(x => x.NumberOfSeats).IsRequired();
            builder.Property(x => x.NumberOfOccupiedSeats).HasDefaultValue(0);


            builder.ToTable("TravelPlans");
        }
    }


}