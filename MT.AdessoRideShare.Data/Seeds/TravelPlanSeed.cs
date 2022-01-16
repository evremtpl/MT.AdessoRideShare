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
                ToWhere = "A",
                FromWhere="F",
                NumberOfSeats=5,
                TravelTime =DateTime.Now,
                Explanation= "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.",
                Route= "A,B,C,D,E,F"

            },
            new TravelPlan
            {
                Id = _ids[1],
                ToWhere = "A",
                FromWhere = "L",
                NumberOfSeats = 7,
                TravelTime = DateTime.Now,
                Explanation = "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.",
                Route= "A,B,O,H,E,L"
            });
        }
    }
}
