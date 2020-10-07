using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Players_registration.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public int Rating { get; set; }
        [ForeignKey("Team")] 
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
