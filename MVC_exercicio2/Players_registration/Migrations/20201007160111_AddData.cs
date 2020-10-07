using Microsoft.EntityFrameworkCore.Migrations;

namespace Players_registration.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "MaxPlayersNumber", "Name" },
                values: new object[] { 1, 2, "Bulls" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "MaxPlayersNumber", "Name" },
                values: new object[] { 2, 2, "Eagles" });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "Name", "Password", "Points", "Rating", "TeamId" },
                values: new object[,]
                {
                    { 2, "Bull", "5678", 300, 6, 1 },
                    { 4, "Dumb", "8765", 50, 2, 1 },
                    { 1, "Champ", "1234", 500, 9, 2 },
                    { 3, "Nubb", "4321", 10, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Tournament",
                columns: new[] { "Id", "Name", "Rating", "TeamId", "Type", "Votes" },
                values: new object[,]
                {
                    { 1, "Inferno", 10, 1, "Deathmatch", 35 },
                    { 2, "Office", 6, 2, "CaptureFlag", 15 },
                    { 3, "Dust", 8, 2, "Deathmatch", 25 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
