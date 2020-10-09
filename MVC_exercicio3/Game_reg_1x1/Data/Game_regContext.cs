using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Game_reg_1x1.Models;

namespace Game_reg_1x1.Data
{
    public class Game_regContext : DbContext
    {
        public Game_regContext (DbContextOptions<Game_regContext> options)
            : base(options)
        {
        }

        public DbSet<Game_reg_1x1.Models.Player> Player { get; set; }

        public DbSet<Game_reg_1x1.Models.Game> Game { get; set; }

        public DbSet<Game_reg_1x1.Models.Tournament> Tournament { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player() { Id = 1, Name = "Kramnik", Rating = 6, Victories = 4, Fails = 3 },
                new Player() { Id = 2, Name = "Karpov", Rating = 8, Victories = 8, Fails = 1 },
                new Player() { Id = 3, Name = "Carlsen", Rating = 10, Victories = 9, Fails = 1 },
                new Player() { Id = 4, Name = "Caruana", Rating = 10, Victories = 10, Fails = 2 }
                );
            modelBuilder.Entity<Game>().HasData(
                new Game() { Id = 1, Name = "1st round", Date = new DateTime(2020, 10, 08), Player1Id = 1, Player2Id = 2, GameWinnerId = 2, TournamentId = 1},
                new Game() { Id = 2, Name = "2nd round", Date = new DateTime(2020, 10, 10), Player1Id = 3, Player2Id = 4, GameWinnerId = 3, TournamentId = 1},
                new Game() { Id = 3, Name = "3nd round", Date = new DateTime(2020, 10, 15), Player1Id = 2, Player2Id = 3, GameWinnerId = 3, TournamentId = 1}
                );
            modelBuilder.Entity<Tournament>().HasData(new Tournament() { Id = 1, Name = "Grand prix", WinnerId = 3});
            base.OnModelCreating(modelBuilder);
        }
    }
}
