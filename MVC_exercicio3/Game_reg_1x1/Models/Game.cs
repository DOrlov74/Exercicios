using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Game_reg_1x1.Models
{
    [Table("Games")]
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Player1Id")] 
        public int Player1Id { get; set; }
        public Player Player1 { get; set; }
        [ForeignKey("Player2Id")]
        public int Player2Id { get; set; }
        public Player Player2 { get; set; }
        [ForeignKey("GameWinnerId")]
        public int GameWinnerId { get; set; }
        public Player GameWinner { get; set; }
        [ForeignKey("TournamentId")]
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
    }
}
