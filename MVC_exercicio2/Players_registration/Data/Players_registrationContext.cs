using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Players_registration.Models;

namespace Players_registration.Data
{
    public class Players_registrationContext : DbContext
    {
        public Players_registrationContext (DbContextOptions<Players_registrationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Team team1 = new Team() {Id = 1, Name = "Bulls", MaxPlayersNumber = 2};
            Team team2 = new Team() { Id = 2, Name = "Eagles", MaxPlayersNumber = 2 };
            modelBuilder.Entity<Player>().HasData(new Player()
                {Id = 1, Name = "Champ", Password = "1234", Points = 500, Rating = 9, TeamId = team2.Id},
                new Player()
                    { Id = 2, Name = "Bull", Password = "5678", Points = 300, Rating = 6, TeamId = team1.Id},
                new Player()
                    { Id = 3, Name = "Nubb", Password = "4321", Points = 10, Rating = 1, TeamId = team2.Id},
                new Player()
                    { Id = 4, Name = "Dumb", Password = "8765", Points = 50, Rating = 2, TeamId = team1.Id});
            modelBuilder.Entity<Team>().HasData(team1, team2);
            modelBuilder.Entity<Tournament>().HasData(new Tournament()
                    { Id = 1, Name = "Inferno", Rating = 10, Type = "Deathmatch", Votes = 35, TeamId = team1.Id },
                new Tournament()
                    { Id = 2, Name = "Office", Rating = 6, Type = "CaptureFlag", Votes = 15, TeamId = team2.Id },
                new Tournament()
                    { Id = 3, Name = "Dust", Rating = 8, Type = "Deathmatch", Votes = 25, TeamId = team2.Id });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Tournament> Tournament { get; set; }
    }
}
