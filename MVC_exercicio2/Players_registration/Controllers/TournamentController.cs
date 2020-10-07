using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Players_registration.Data;
using Players_registration.Models;
using Players_registration.ViewModels;

namespace Players_registration.Controllers
{
    public class TournamentController : Controller
    {
        private readonly Players_registrationContext _context;

        public TournamentController(Players_registrationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Tournaments table";
            List<TournamentTeam> tournaments = new List<TournamentTeam>();
            foreach (Tournament t in _context.Tournament)
            {
                tournaments.Add(new TournamentTeam()
                {
                    Tournament = t,
                    Team = (from team in _context.Team
                        where team.Id == t.TeamId
                        select team).First()
                });
            };
            return View(tournaments);
        }
    }
}
