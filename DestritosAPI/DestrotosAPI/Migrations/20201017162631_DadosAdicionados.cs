using Microsoft.EntityFrameworkCore.Migrations;

namespace DestritosAPI.Migrations
{
    public partial class DadosAdicionados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Distrito",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lisboa" },
                    { 2, "Porto" },
                    { 3, "Beja" },
                    { 4, "Braga" },
                    { 5, "Coimbra" }
                });

            migrationBuilder.InsertData(
                table: "Conselho",
                columns: new[] { "Id", "DistritoId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Lisboa" },
                    { 23, 5, "Mira" },
                    { 22, 5, "Góis" },
                    { 21, 5, "Coimbra" },
                    { 20, 4, "Visela" },
                    { 19, 4, "Guimarães" },
                    { 18, 4, "Amares" },
                    { 17, 4, "Barcelos" },
                    { 16, 4, "Braga" },
                    { 15, 3, "Ourique" },
                    { 14, 3, "Alvito" },
                    { 24, 5, "Penela" },
                    { 13, 3, "Moura" },
                    { 11, 3, "Beja" },
                    { 10, 2, "Trofa" },
                    { 9, 2, "Lousada" },
                    { 8, 2, "Maia" },
                    { 7, 2, "Gondomar" },
                    { 6, 2, "Porto" },
                    { 5, 1, "Sintra" },
                    { 4, 1, "Odivelas" },
                    { 3, 1, "Cascais" },
                    { 2, 1, "Amadora" },
                    { 12, 3, "Cuba" },
                    { 25, 5, "Soure" }
                });

            migrationBuilder.InsertData(
                table: "Freguesia",
                columns: new[] { "Id", "ConselhoId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Areeiro" },
                    { 69, 19, "Barco" },
                    { 68, 19, "Aldão" },
                    { 67, 18, "Lago" },
                    { 66, 18, "Fiscal" },
                    { 65, 18, "Caires" },
                    { 64, 18, "Bico" },
                    { 63, 18, "Barreiros" },
                    { 62, 18, "Amares e Figueiredo" },
                    { 61, 17, "Silva" },
                    { 70, 19, "Brito" },
                    { 60, 17, "Cristelo" },
                    { 58, 17, "Aborim" },
                    { 57, 17, "Barcelos" },
                    { 56, 16, "Merelim" },
                    { 55, 16, "Lamas" },
                    { 54, 16, "Espinho" },
                    { 53, 16, "Adaúfe" },
                    { 52, 16, "Braga" },
                    { 51, 15, "Santana da Serra" },
                    { 50, 15, "Garxão e Santa Luzia" },
                    { 59, 17, "Areias" },
                    { 49, 15, "Ourique" },
                    { 71, 19, "Caldelas" },
                    { 73, 19, "Pinheiro" },
                    { 93, 25, "Granja do Ulmeiro" },
                    { 92, 25, "Alfarelos" },
                    { 91, 25, "Soure" },
                    { 90, 24, "Podentes" },
                    { 89, 24, "Espinhal" },
                    { 88, 24, "Cumeeira" },
                    { 87, 23, "Seixo" },
                    { 86, 23, "Praia de Mira" },
                    { 85, 23, "Carapelhos" },
                    { 72, 19, "Costa" },
                    { 84, 23, "Mira" },
                    { 82, 22, "Góis" },
                    { 81, 21, "Torres do Mondego" },
                    { 80, 21, "Santa Clara e Castelo" },
                    { 79, 21, "São Silvestre" },
                    { 78, 21, "Ceira" },
                    { 77, 21, "Coimbra" },
                    { 76, 20, "Infias" },
                    { 75, 20, "Caldas Da Visela" },
                    { 74, 19, "Ponte" },
                    { 83, 22, "Cadafaz e Colmeal" },
                    { 94, 25, "Samuel" },
                    { 48, 14, "Alvito" },
                    { 46, 12, "Cuba" },
                    { 21, 5, "Rio de Mouro" },
                    { 20, 5, "Queluz e Belas" },
                    { 19, 5, "Casal de Cambra" },
                    { 18, 5, "Sintra" },
                    { 17, 4, "Ramada e Caneças" },
                    { 16, 4, "Pontinha e Famões" },
                    { 15, 4, "Odivelas" },
                    { 14, 3, "São Domingos de Rana" },
                    { 13, 3, "Alcabideche" },
                    { 22, 6, "Bonfim" },
                    { 12, 3, "Carcavelos e Parede" },
                    { 10, 2, "Águas livres" },
                    { 9, 2, "Venteira" },
                    { 8, 2, "Mina de Água" },
                    { 7, 2, "Encosta do sol" },
                    { 6, 2, "Alfragide" },
                    { 5, 1, "Olivais" },
                    { 4, 1, "Lumiar" },
                    { 3, 1, "Campolide" },
                    { 2, 1, "Beato" },
                    { 11, 3, "Cascais e Estoril" },
                    { 47, 13, "Moura" },
                    { 23, 6, "Campanhã" },
                    { 25, 6, "Ramalde" },
                    { 45, 11, "Baleizão" },
                    { 44, 11, "Beja" },
                    { 43, 10, "Coronado" },
                    { 42, 10, "Muro" },
                    { 41, 10, "Covelas" },
                    { 40, 10, "Bougado" },
                    { 39, 9, "Sousela" },
                    { 38, 9, "Meinedo" },
                    { 37, 9, "Macieira" },
                    { 24, 6, "Paranhos" },
                    { 36, 9, "Lodares" },
                    { 34, 8, "Vila Nova de Telha" },
                    { 33, 8, "São Pedro Fins" },
                    { 32, 8, "Pedrouços" },
                    { 31, 8, "Folgosa" },
                    { 30, 8, "Moreira" },
                    { 29, 7, "Rio Tinto" },
                    { 28, 7, "Melres e Medas" },
                    { 27, 7, "Lomba" },
                    { 26, 7, "Gondomar" },
                    { 35, 9, "Aveleda" },
                    { 95, 25, "Tapéus" }
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "ConselhoId", "DistritoId", "FreguesiaId", "Name" },
                values: new object[] { 1, 2, 1, 3, "Pedro" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "ConselhoId", "DistritoId", "FreguesiaId", "Name" },
                values: new object[] { 2, 11, 3, 45, "Joana" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "ConselhoId", "DistritoId", "FreguesiaId", "Name" },
                values: new object[] { 3, 19, 4, 70, "Miguel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Freguesia",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Conselho",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Distrito",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Distrito",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Distrito",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Distrito",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Distrito",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
