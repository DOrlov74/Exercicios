using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Game_reg_1x1.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int Victories { get; set; }
        public int Fails { get; set; }
        [InverseProperty("Player1")]
        public List<Game> Player1Games { get; set; }
        [InverseProperty("Player2")]
        public List<Game> Player2Games { get; set; }
        [InverseProperty("GameWinner")]
        public List<Game> WinnedGames { get; set; }
    }
}
