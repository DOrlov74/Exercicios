using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Players_registration.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPlayersNumber { get; set; }
        public List<Player> Players { get; set; }
        public List<Tournament> Tournaments { get; set; }
    }
}
