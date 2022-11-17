using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name" },
                values: new object[] { 20, "League 1" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Name" },
                values: new object[] { 20, 20, "Team 1" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Name" },
                values: new object[] { 21, 20, "Team 2" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Name" },
                values: new object[] { 22, 20, "Team 3" });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[] { 20, "Jon Kristensen 1", 20 });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[] { 21, "Jon Kristensen 2", 21 });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "Name", "TeamId" },
                values: new object[] { 22, "Jon Kristensen 3", 22 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
