using Microsoft.EntityFrameworkCore.Migrations;

namespace DestritosAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distrito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distrito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conselho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DistritoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conselho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conselho_Distrito_DistritoId",
                        column: x => x.DistritoId,
                        principalTable: "Distrito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Freguesia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ConselhoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freguesia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Freguesia_Conselho_ConselhoId",
                        column: x => x.ConselhoId,
                        principalTable: "Conselho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DistritoId = table.Column<int>(nullable: false),
                    ConselhoId = table.Column<int>(nullable: false),
                    FreguesiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Conselho_ConselhoId",
                        column: x => x.ConselhoId,
                        principalTable: "Conselho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoas_Distrito_DistritoId",
                        column: x => x.DistritoId,
                        principalTable: "Distrito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Pessoas_Freguesia_FreguesiaId",
                        column: x => x.FreguesiaId,
                        principalTable: "Freguesia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conselho_DistritoId",
                table: "Conselho",
                column: "DistritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Freguesia_ConselhoId",
                table: "Freguesia",
                column: "ConselhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_ConselhoId",
                table: "Pessoas",
                column: "ConselhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DistritoId",
                table: "Pessoas",
                column: "DistritoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_FreguesiaId",
                table: "Pessoas",
                column: "FreguesiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Freguesia");

            migrationBuilder.DropTable(
                name: "Conselho");

            migrationBuilder.DropTable(
                name: "Distrito");
        }
    }
}
