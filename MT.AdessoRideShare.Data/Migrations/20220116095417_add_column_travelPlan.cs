using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT.AdessoRideShare.Data.Migrations
{
    public partial class add_column_travelPlan : Migration
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
                    Explanation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                columns: new[] { "Id", "Explanation", "FromWhere", "NumberOfSeats", "Route", "ToWhere", "TravelTime" },
                values: new object[,]
                {
                    { 1, "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.", "F", 5, "A,B,C,D,E,F", "A", new DateTime(2022, 1, 16, 12, 54, 17, 12, DateTimeKind.Local).AddTicks(3474) },
                    { 2, "Seyehat Dizel araçla 100 km hızda 2 mola vererek gerçeklestirilecektir.", "L", 7, "A,B,O,H,E,L", "A", new DateTime(2022, 1, 16, 12, 54, 17, 14, DateTimeKind.Local).AddTicks(5697) }
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
