using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.AdessoRideShare.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TravelPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromWhere = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ToWhere = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TravelTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    NumberOfOccupiedSeats = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Explanation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTravelPlans",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TravelPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTravelPlans", x => new { x.UserId, x.TravelPlanId });
                    table.ForeignKey(
                        name: "FK_UserTravelPlans_TravelPlans_TravelPlanId",
                        column: x => x.TravelPlanId,
                        principalTable: "TravelPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTravelPlans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TravelPlans",
                columns: new[] { "Id", "Explanation", "FromWhere", "NumberOfSeats", "ToWhere", "TravelTime" },
                values: new object[,]
                {
                    { 1, "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.", "ankara", 5, "istanbul", new DateTime(2022, 1, 16, 1, 54, 36, 959, DateTimeKind.Local).AddTicks(1644) },
                    { 2, "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.", "Iğdır", 7, "ankara", new DateTime(2022, 1, 16, 1, 54, 36, 962, DateTimeKind.Local).AddTicks(6468) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "SurName" },
                values: new object[,]
                {
                    { 1, "jack", "Nicholson" },
                    { 2, "Russell", "Crowe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTravelPlans_TravelPlanId",
                table: "UserTravelPlans",
                column: "TravelPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTravelPlans");

            migrationBuilder.DropTable(
                name: "TravelPlans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
