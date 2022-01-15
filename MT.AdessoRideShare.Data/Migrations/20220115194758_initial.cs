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
                    WhereFrom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ToWhere = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TravelTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
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
                name: "TravelPlanUser",
                columns: table => new
                {
                    TravelPlansId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlanUser", x => new { x.TravelPlansId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TravelPlanUser_TravelPlans_TravelPlansId",
                        column: x => x.TravelPlansId,
                        principalTable: "TravelPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelPlanUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlanUser_UsersId",
                table: "TravelPlanUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelPlanUser");

            migrationBuilder.DropTable(
                name: "TravelPlans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
