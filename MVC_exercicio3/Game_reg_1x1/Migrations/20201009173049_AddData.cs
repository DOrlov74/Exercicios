using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Game_reg_1x1.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameWinnerId",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Fails", "Name", "Rating", "Victories" },
                values: new object[,]
                {
                    { 1, 3, "Kramnik", 6, 4 },
                    { 2, 1, "Karpov", 8, 8 },
                    { 3, 1, "Carlsen", 10, 9 },
                    { 4, 2, "Caruana", 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "Name", "WinnerId" },
                values: new object[] { 1, "Grand prix", 3 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Date", "GameWinnerId", "Name", "Player1Id", "Player2Id", "TournamentId" },
                values: new object[] { 1, new DateTime(2020, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "1st round", 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Date", "GameWinnerId", "Name", "Player1Id", "Player2Id", "TournamentId" },
                values: new object[] { 2, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "2nd round", 3, 4, 1 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Date", "GameWinnerId", "Name", "Player1Id", "Player2Id", "TournamentId" },
                values: new object[] { 3, new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "3nd round", 2, 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameWinnerId",
                table: "Games",
                column: "GameWinnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Players_GameWinnerId",
                table: "Games",
                column: "GameWinnerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Players_GameWinnerId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GameWinnerId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tournaments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "GameWinnerId",
                table: "Games");
        }
    }
}
