using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Players_registration.Data;
using Players_registration.Models;
using Players_registration.ViewModels;

namespace Players_registration.Controllers
{
    public class PlayerController : Controller
    {
        private readonly Players_registrationContext _context;

        public PlayerController(Players_registrationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Players table";
            List<PlayerTeam> players = new List<PlayerTeam>();
            foreach (Player p in _context.Player)
            {
                players.Add(new PlayerTeam()
                {
                    Player = p, 
                    Team = (from team in _context.Team
                        where team.Id==p.TeamId
                           select team).First()
                });
            }; 
            return View(players);
        }
    }
}
