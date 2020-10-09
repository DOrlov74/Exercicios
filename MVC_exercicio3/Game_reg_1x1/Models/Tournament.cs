using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Game_reg_1x1.Models
{
    [Table("Tournaments")]
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("WinnerId")] 
        public int WinnerId { get; set; }
        public Player Winner { get; set; }
        public List<Game> Games { get; set; }
    }
}
