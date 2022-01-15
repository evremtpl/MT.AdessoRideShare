using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MT.AdessoRideShare.Core.Entity;


namespace MT.AdessoRideShare.Data.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly int[] _ids;

        public UserSeed(int[] ids)
        {
            _ids = ids;

        }
       

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                Id = _ids[0],
                Name = "jack",
                SurName = "Nicholson",
               

            },
            new User
            {
                Id = _ids[1],
                Name = "Russell",
                SurName = "Crowe",


            });
        }
    }
}
