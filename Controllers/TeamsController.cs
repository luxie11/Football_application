using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballApplication.Models;
using FootballApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballApplication.Controllers
{
    public class TeamsController : Controller
    {

        private readonly footballappContext _context;

        public TeamsController(footballappContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Team> teamList = await _context.Team.ToListAsync();

            var players = await (from player in _context.Players
                           join team in _context.Team on player.FkPlayerTeam equals team.IdTeam
                           select player).ToListAsync();

            TeamDetails teamDetails = new TeamDetails();
            teamDetails.Players = players;
            teamDetails.Team = teamList;

            return View(teamDetails);
        }
    }
}