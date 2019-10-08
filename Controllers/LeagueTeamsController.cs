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
    public class LeagueTeamsController : Controller
    {
        private readonly footballappContext _context;

        public LeagueTeamsController(footballappContext context)
        {
            _context = context;
        }

        //[Route("LeagueTeams/{id}")] --> Klausimas, kuris geresnis routinimas? 
        //Startup'e ar su anotacija?
        public async Task<IActionResult> Index(int id)
        {
            string leagueName = _context.Leagues.Where(el => el.IdLeagues == id)
                                                .Select(el => el.Name)
                                                .FirstOrDefault();
            ViewData["League-Title"] = leagueName;
            var leagueTeams = (from leagueTable in _context.LeagueTeams
                               join team in _context.Team on leagueTable.FkTeamId equals team.IdTeam
                               select new LeagueTableDetails {
                                   leagueID = leagueTable.FkLeaguesId,
                                   teamCrest = team.CrestUrl,
                                   teamName = team.TeamName,
                                   matchesPlayed = leagueTable.MatchesPlayed,
                                   wins = leagueTable.Wins,
                                   draws = leagueTable.Draws,
                                   loses = leagueTable.Loses,
                                   goalsScored = leagueTable.GoalsScored,
                                   goalsConceded = leagueTable.GoalsConceded,
                                   goalsDifference = leagueTable.GoalsScored - leagueTable.GoalsConceded,
                                   points = leagueTable.Points

                               })
                               .Where(el => el.leagueID == id)
                               .OrderByDescending(el => el.points)
                               .ToListAsync();
            return View(await leagueTeams);
        }
    }
}