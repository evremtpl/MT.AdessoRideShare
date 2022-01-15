using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MT.AdessoRideShare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.Data.Configurations
{
    class UserTravelPlanConfiguration : IEntityTypeConfiguration<UserTravelPlan>
    {
        public void Configure(EntityTypeBuilder<UserTravelPlan> builder)
        {
            builder
        .HasKey(utp => new { utp.UserId, utp.TravelPlanId });
            builder
                .HasOne(utp => utp.User)
                .WithMany(u => u.UserTravelPlans)
                .HasForeignKey(utp => utp.UserId);
            builder
                .HasOne(utp => utp.TravelPlan)
                .WithMany(tp => tp.UserTravelPlans)
                .HasForeignKey(utp => utp.TravelPlanId);
        }
    }
}

