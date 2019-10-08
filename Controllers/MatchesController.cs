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
    public class MatchesController : Controller
    {
        private readonly footballappContext _context;

        public MatchesController(footballappContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        {
            var matchesList = (from matches in _context.Matches
                            join homeTeam in _context.Team on matches.FkHomeTeamId equals homeTeam.IdTeam
                            join awayTeam in _context.Team on matches.FkAwayTeamId equals awayTeam.IdTeam
                            select new MatchDetails {
                                id = matches.IdMatches,
                                matchTime = matches.MatchTime,
                                homeTeamName = homeTeam.TeamName,
                                homeTeamCrest = homeTeam.CrestUrl,
                                homeTeamScore = matches.HomeTeamScore,
                                awayTeamName = awayTeam.TeamName,
                                awayTeamCrest = awayTeam.CrestUrl,
                                awayTeamScore = matches.AwayTeamScore,
                                gameWeek = matches.GameWeek
                            }).OrderBy(model => model.matchTime).ToListAsync();
            return View(await matchesList);
        }
    }
}