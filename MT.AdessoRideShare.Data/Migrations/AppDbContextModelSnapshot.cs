// <auto-generated />
using System;
using MT.AdessoRideShare.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT.AdessoRideShare.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT.AdessoRideShare.Core.Entity.TravelPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("FromWhere")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("NumberOfOccupiedSeats")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("Route")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToWhere")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("TravelTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TravelPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Explanation = "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.",
                            FromWhere = "F",
                            NumberOfOccupiedSeats = 0,
                            NumberOfSeats = 5,
                            Route = "A,B,C,D,E,F",
                            ToWhere = "A",
                            TravelTime = new DateTime(2022, 1, 16, 12, 54, 17, 12, DateTimeKind.Local).AddTicks(3474)
                        },
                        new
                        {
                            Id = 2,
                            Explanation = "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.",
                            FromWhere = "L",
                            NumberOfOccupiedSeats = 0,
                            NumberOfSeats = 7,
                            Route = "A,B,O,H,E,L",
                            ToWhere = "A",
                            TravelTime = new DateTime(2022, 1, 16, 12, 54, 17, 14, DateTimeKind.Local).AddTicks(5697)
                        });
                });

            modelBuilder.Entity("MT.AdessoRideShare.Core.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "jack",
                            SurName = "Nicholson"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Russell",
                            SurName = "Crowe"
                        });
                });

            modelBuilder.Entity("MT.AdessoRideShare.Core.Entity.UserTravelPlan", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TravelPlanId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "TravelPlanId");

                    b.HasIndex("TravelPlanId");

                    b.ToTable("UserTravelPlans");
                });

            modelBuilder.Entity("MT.AdessoRideShare.Core.Entity.UserTravelPlan", b =>
                {
                    b.HasOne("MT.AdessoRideShare.Core.Entity.TravelPlan", "TravelPlan")
                        .WithMany("UserTravelPlans")
                        .HasForeignKey("TravelPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MT.AdessoRideShare.Core.Entity.User", "User")
                        .WithMany("UserTravelPlans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelPlan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MT.AdessoRideShare.Core.Entity.TravelPlan", b =>
                {
                    b.Navigation("UserTravelPlans");
                });

            modelBuilder.Entity("MT.AdessoRideShare.Core.Entity.User", b =>
                {
                    b.Navigation("UserTravelPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
