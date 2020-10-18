using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DestritosAPI.Models;

namespace DestritosAPI.Data
{
    public class DestritosAPIContext : DbContext
    {
        public DestritosAPIContext (DbContextOptions<DestritosAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Conselho> Conselhos { get; set; }
        public DbSet<Freguesia> Freguesias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Distrito>().HasData(
                new Distrito() { Id = 1, Name = "Lisboa"},
                new Distrito() { Id = 2, Name = "Porto" },
                new Distrito() { Id = 3, Name = "Beja" },
                new Distrito() { Id = 4, Name = "Braga" },
                new Distrito() { Id = 5, Name = "Coimbra" }
            );
            modelBuilder.Entity<Conselho>().HasData(
                new Conselho() { Id = 1, Name = "Lisboa", DistritoId = 1},
                new Conselho() { Id = 2, Name = "Amadora", DistritoId = 1 },
                new Conselho() { Id = 3, Name = "Cascais", DistritoId = 1 },
                new Conselho() { Id = 4, Name = "Odivelas", DistritoId = 1 },
                new Conselho() { Id = 5, Name = "Sintra", DistritoId = 1 },
                new Conselho() { Id = 6, Name = "Porto", DistritoId = 2 },
                new Conselho() { Id = 7, Name = "Gondomar", DistritoId = 2 },
                new Conselho() { Id = 8, Name = "Maia", DistritoId = 2 },
                new Conselho() { Id = 9, Name = "Lousada", DistritoId = 2 },
                new Conselho() { Id = 10, Name = "Trofa", DistritoId = 2 },
                new Conselho() { Id = 11, Name = "Beja", DistritoId = 3 },
                new Conselho() { Id = 12, Name = "Cuba", DistritoId = 3 },
                new Conselho() { Id = 13, Name = "Moura", DistritoId = 3 },
                new Conselho() { Id = 14, Name = "Alvito", DistritoId = 3 },
                new Conselho() { Id = 15, Name = "Ourique", DistritoId = 3 },
                new Conselho() { Id = 16, Name = "Braga", DistritoId = 4 },
                new Conselho() { Id = 17, Name = "Barcelos", DistritoId = 4 },
                new Conselho() { Id = 18, Name = "Amares", DistritoId = 4 },
                new Conselho() { Id = 19, Name = "Guimarães", DistritoId = 4 },
                new Conselho() { Id = 20, Name = "Visela", DistritoId = 4 },
                new Conselho() { Id = 21, Name = "Coimbra", DistritoId = 5 },
                new Conselho() { Id = 22, Name = "Góis", DistritoId = 5 },
                new Conselho() { Id = 23, Name = "Mira", DistritoId = 5 },
                new Conselho() { Id = 24, Name = "Penela", DistritoId = 5 },
                new Conselho() { Id = 25, Name = "Soure", DistritoId = 5 }
            );
            modelBuilder.Entity<Freguesia>().HasData(
                new Freguesia() { Id = 1, Name = "Areeiro", ConselhoId = 1},
                new Freguesia() { Id = 2, Name = "Beato", ConselhoId = 1 },
                new Freguesia() { Id = 3, Name = "Campolide", ConselhoId = 1 },
                new Freguesia() { Id = 4, Name = "Lumiar", ConselhoId = 1 },
                new Freguesia() { Id = 5, Name = "Olivais", ConselhoId = 1 },
                new Freguesia() { Id = 6, Name = "Alfragide", ConselhoId = 2},
                new Freguesia() { Id = 7, Name = "Encosta do sol", ConselhoId = 2 },
                new Freguesia() { Id = 8, Name = "Mina de Água", ConselhoId = 2 },
                new Freguesia() { Id = 9, Name = "Venteira", ConselhoId = 2 },
                new Freguesia() { Id = 10, Name = "Águas livres", ConselhoId = 2 },
                new Freguesia() { Id = 11, Name = "Cascais e Estoril", ConselhoId = 3},
                new Freguesia() { Id = 12, Name = "Carcavelos e Parede", ConselhoId = 3 },
                new Freguesia() { Id = 13, Name = "Alcabideche", ConselhoId = 3 },
                new Freguesia() { Id = 14, Name = "São Domingos de Rana", ConselhoId = 3 },
                new Freguesia() { Id = 15, Name = "Odivelas", ConselhoId = 4},
                new Freguesia() { Id = 16, Name = "Pontinha e Famões", ConselhoId = 4 },
                new Freguesia() { Id = 17, Name = "Ramada e Caneças", ConselhoId = 4 },
                new Freguesia() { Id = 18, Name = "Sintra", ConselhoId = 5},
                new Freguesia() { Id = 19, Name = "Casal de Cambra", ConselhoId = 5 },
                new Freguesia() { Id = 20, Name = "Queluz e Belas", ConselhoId = 5 },
                new Freguesia() { Id = 21, Name = "Rio de Mouro", ConselhoId = 5 },
                new Freguesia() { Id = 22, Name = "Bonfim", ConselhoId = 6 },
                new Freguesia() { Id = 23, Name = "Campanhã", ConselhoId = 6 },
                new Freguesia() { Id = 24, Name = "Paranhos", ConselhoId = 6 },
                new Freguesia() { Id = 25, Name = "Ramalde", ConselhoId = 6 },
                new Freguesia() { Id = 26, Name = "Gondomar", ConselhoId = 7 },
                new Freguesia() { Id = 27, Name = "Lomba", ConselhoId = 7 },
                new Freguesia() { Id = 28, Name = "Melres e Medas", ConselhoId = 7 },
                new Freguesia() { Id = 29, Name = "Rio Tinto", ConselhoId = 7 },
                new Freguesia() { Id = 30, Name = "Moreira", ConselhoId = 8 },
                new Freguesia() { Id = 31, Name = "Folgosa", ConselhoId = 8 },
                new Freguesia() { Id = 32, Name = "Pedrouços", ConselhoId = 8 },
                new Freguesia() { Id = 33, Name = "São Pedro Fins", ConselhoId = 8 },
                new Freguesia() { Id = 34, Name = "Vila Nova de Telha", ConselhoId = 8 },
                new Freguesia() { Id = 35, Name = "Aveleda", ConselhoId = 9 },
                new Freguesia() { Id = 36, Name = "Lodares", ConselhoId = 9 },
                new Freguesia() { Id = 37, Name = "Macieira", ConselhoId = 9 },
                new Freguesia() { Id = 38, Name = "Meinedo", ConselhoId = 9 },
                new Freguesia() { Id = 39, Name = "Sousela", ConselhoId = 9 },
                new Freguesia() { Id = 40, Name = "Bougado", ConselhoId = 10 },
                new Freguesia() { Id = 41, Name = "Covelas", ConselhoId = 10 },
                new Freguesia() { Id = 42, Name = "Muro", ConselhoId = 10 },
                new Freguesia() { Id = 43, Name = "Coronado", ConselhoId = 10 },
                new Freguesia() { Id = 44, Name = "Beja", ConselhoId = 11 },
                new Freguesia() { Id = 45, Name = "Baleizão", ConselhoId = 11 },
                new Freguesia() { Id = 46, Name = "Cuba", ConselhoId = 12 },
                new Freguesia() { Id = 47, Name = "Moura", ConselhoId = 13 },
                new Freguesia() { Id = 48, Name = "Alvito", ConselhoId = 14 },
                new Freguesia() { Id = 49, Name = "Ourique", ConselhoId = 15 },
                new Freguesia() { Id = 50, Name = "Garxão e Santa Luzia", ConselhoId = 15 },
                new Freguesia() { Id = 51, Name = "Santana da Serra", ConselhoId = 15 },
                new Freguesia() { Id = 52, Name = "Braga", ConselhoId = 16 },
                new Freguesia() { Id = 53, Name = "Adaúfe", ConselhoId = 16 },
                new Freguesia() { Id = 54, Name = "Espinho", ConselhoId = 16 },
                new Freguesia() { Id = 55, Name = "Lamas", ConselhoId = 16 },
                new Freguesia() { Id = 56, Name = "Merelim", ConselhoId = 16 },
                new Freguesia() { Id = 57, Name = "Barcelos", ConselhoId = 17 },
                new Freguesia() { Id = 58, Name = "Aborim", ConselhoId = 17 },
                new Freguesia() { Id = 59, Name = "Areias", ConselhoId = 17 },
                new Freguesia() { Id = 60, Name = "Cristelo", ConselhoId = 17 },
                new Freguesia() { Id = 61, Name = "Silva", ConselhoId = 17 },
                new Freguesia() { Id = 62, Name = "Amares e Figueiredo", ConselhoId = 18 },
                new Freguesia() { Id = 63, Name = "Barreiros", ConselhoId = 18 },
                new Freguesia() { Id = 64, Name = "Bico", ConselhoId = 18 },
                new Freguesia() { Id = 65, Name = "Caires", ConselhoId = 18 },
                new Freguesia() { Id = 66, Name = "Fiscal", ConselhoId = 18 },
                new Freguesia() { Id = 67, Name = "Lago", ConselhoId = 18 },
                new Freguesia() { Id = 68, Name = "Aldão", ConselhoId = 19 },
                new Freguesia() { Id = 69, Name = "Barco", ConselhoId = 19 },
                new Freguesia() { Id = 70, Name = "Brito", ConselhoId = 19 },
                new Freguesia() { Id = 71, Name = "Caldelas", ConselhoId = 19 },
                new Freguesia() { Id = 72, Name = "Costa", ConselhoId = 19 },
                new Freguesia() { Id = 73, Name = "Pinheiro", ConselhoId = 19 },
                new Freguesia() { Id = 74, Name = "Ponte", ConselhoId = 19 },
                new Freguesia() { Id = 75, Name = "Caldas Da Visela", ConselhoId = 20 },
                new Freguesia() { Id = 76, Name = "Infias", ConselhoId = 20 },
                new Freguesia() { Id = 77, Name = "Coimbra", ConselhoId = 21 },
                new Freguesia() { Id = 78, Name = "Ceira", ConselhoId = 21 },
                new Freguesia() { Id = 79, Name = "São Silvestre", ConselhoId = 21 },
                new Freguesia() { Id = 80, Name = "Santa Clara e Castelo", ConselhoId = 21 },
                new Freguesia() { Id = 81, Name = "Torres do Mondego", ConselhoId = 21 },
                new Freguesia() { Id = 82, Name = "Góis", ConselhoId = 22 },
                new Freguesia() { Id = 83, Name = "Cadafaz e Colmeal", ConselhoId = 22 },
                new Freguesia() { Id = 84, Name = "Mira", ConselhoId = 23 },
                new Freguesia() { Id = 85, Name = "Carapelhos", ConselhoId = 23 },
                new Freguesia() { Id = 86, Name = "Praia de Mira", ConselhoId = 23 },
                new Freguesia() { Id = 87, Name = "Seixo", ConselhoId = 23 },
                new Freguesia() { Id = 88, Name = "Cumeeira", ConselhoId = 24 },
                new Freguesia() { Id = 89, Name = "Espinhal", ConselhoId = 24 },
                new Freguesia() { Id = 90, Name = "Podentes", ConselhoId = 24 },
                new Freguesia() { Id = 91, Name = "Soure", ConselhoId = 25 },
                new Freguesia() { Id = 92, Name = "Alfarelos", ConselhoId = 25 },
                new Freguesia() { Id = 93, Name = "Granja do Ulmeiro", ConselhoId = 25 },
                new Freguesia() { Id = 94, Name = "Samuel", ConselhoId = 25 },
                new Freguesia() { Id = 95, Name = "Tapéus", ConselhoId = 25 }
            );
            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa() { Id = 1, Name = "Pedro", DistritoId = 1, ConselhoId = 2, FreguesiaId = 3},
                new Pessoa() { Id = 2, Name = "Joana", DistritoId = 3, ConselhoId = 11, FreguesiaId = 45 },
                new Pessoa() { Id = 3, Name = "Miguel", DistritoId = 4, ConselhoId = 19, FreguesiaId = 70 }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
