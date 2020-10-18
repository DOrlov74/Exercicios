using Microsoft.EntityFrameworkCore.Migrations;

namespace DestritosAPI.Migrations
{
    public partial class testMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conselho_Distrito_DistritoId",
                table: "Conselho");

            migrationBuilder.DropForeignKey(
                name: "FK_Freguesia_Conselho_ConselhoId",
                table: "Freguesia");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Conselho_ConselhoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Distrito_DistritoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Freguesia_FreguesiaId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Freguesia",
                table: "Freguesia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distrito",
                table: "Distrito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conselho",
                table: "Conselho");

            migrationBuilder.RenameTable(
                name: "Freguesia",
                newName: "Freguesias");

            migrationBuilder.RenameTable(
                name: "Distrito",
                newName: "Distritos");

            migrationBuilder.RenameTable(
                name: "Conselho",
                newName: "Conselhos");

            migrationBuilder.RenameIndex(
                name: "IX_Freguesia_ConselhoId",
                table: "Freguesias",
                newName: "IX_Freguesias_ConselhoId");

            migrationBuilder.RenameIndex(
                name: "IX_Conselho_DistritoId",
                table: "Conselhos",
                newName: "IX_Conselhos_DistritoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Freguesias",
                table: "Freguesias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distritos",
                table: "Distritos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conselhos",
                table: "Conselhos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conselhos_Distritos_DistritoId",
                table: "Conselhos",
                column: "DistritoId",
                principalTable: "Distritos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Freguesias_Conselhos_ConselhoId",
                table: "Freguesias",
                column: "ConselhoId",
                principalTable: "Conselhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Conselhos_ConselhoId",
                table: "Pessoas",
                column: "ConselhoId",
                principalTable: "Conselhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Distritos_DistritoId",
                table: "Pessoas",
                column: "DistritoId",
                principalTable: "Distritos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Freguesias_FreguesiaId",
                table: "Pessoas",
                column: "FreguesiaId",
                principalTable: "Freguesias",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conselhos_Distritos_DistritoId",
                table: "Conselhos");

            migrationBuilder.DropForeignKey(
                name: "FK_Freguesias_Conselhos_ConselhoId",
                table: "Freguesias");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Conselhos_ConselhoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Distritos_DistritoId",
                table: "Pessoas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Freguesias_FreguesiaId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Freguesias",
                table: "Freguesias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distritos",
                table: "Distritos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conselhos",
                table: "Conselhos");

            migrationBuilder.RenameTable(
                name: "Freguesias",
                newName: "Freguesia");

            migrationBuilder.RenameTable(
                name: "Distritos",
                newName: "Distrito");

            migrationBuilder.RenameTable(
                name: "Conselhos",
                newName: "Conselho");

            migrationBuilder.RenameIndex(
                name: "IX_Freguesias_ConselhoId",
                table: "Freguesia",
                newName: "IX_Freguesia_ConselhoId");

            migrationBuilder.RenameIndex(
                name: "IX_Conselhos_DistritoId",
                table: "Conselho",
                newName: "IX_Conselho_DistritoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Freguesia",
                table: "Freguesia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distrito",
                table: "Distrito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conselho",
                table: "Conselho",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conselho_Distrito_DistritoId",
                table: "Conselho",
                column: "DistritoId",
                principalTable: "Distrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Freguesia_Conselho_ConselhoId",
                table: "Freguesia",
                column: "ConselhoId",
                principalTable: "Conselho",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Conselho_ConselhoId",
                table: "Pessoas",
                column: "ConselhoId",
                principalTable: "Conselho",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Distrito_DistritoId",
                table: "Pessoas",
                column: "DistritoId",
                principalTable: "Distrito",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Freguesia_FreguesiaId",
                table: "Pessoas",
                column: "FreguesiaId",
                principalTable: "Freguesia",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
