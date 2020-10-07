using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Players_registration.Models;

namespace Players_registration.ViewModels
{
    public class PlayerTeam
    {
        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
