using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MT.AdessoRideShare.Core.Entity;
using System;

namespace MT.AdessoRideShare.Data.Seeds
{
    class TravelPlanSeed : IEntityTypeConfiguration<TravelPlan>
    {

        private readonly int[] _ids;

        public TravelPlanSeed(int[] ids)
        {
            _ids = ids;

        }
        public void Configure(EntityTypeBuilder<TravelPlan> builder)
        {
            builder.HasData(new TravelPlan
            {
                Id= _ids[0],
                ToWhere = "istanbul",
                FromWhere="ankara",
                NumberOfSeats=5,
                TravelTime =DateTime.Now,
                Explanation= "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir."
            },
            new TravelPlan
            {
                Id = _ids[1],
                ToWhere = "ankara",
                FromWhere = "Iğdır",
                NumberOfSeats = 7,
                TravelTime = DateTime.Now,
                Explanation = "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir."
            });
        }
    }
}
