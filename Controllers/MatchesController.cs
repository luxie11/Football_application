using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballApplication.HelperClasses;
using FootballApplication.Models;
using FootballApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace FootballApplication.Controllers
{
    public class MatchesController : Controller
    {
        private readonly footballappContext _context;

        public MatchesController(footballappContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? page) 
        {
            var matchesList = await (from matches in _context.Matches
                            join homeTeam in _context.Team on matches.FkHomeTeamId equals homeTeam.IdTeam
                            join awayTeam in _context.Team on matches.FkAwayTeamId equals awayTeam.IdTeam
                            select new HeadToHeadMatches {
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
            List<Team> teams = await _context.Team.ToListAsync();
            List<Stadiums> stadiums = await _context.Stadiums.ToListAsync();
            List<Leagues> leagues = await _context.Leagues.ToListAsync();
            HttpContext.Session.Set("Testavimas", Encoding.ASCII.GetBytes("Administratorius"));
            MatchDetails matchDetails = new MatchDetails();
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            matchDetails.HeadToHeadMatches = matchesList.ToPagedList(pageNumber, pageSize);
            matchDetails.TeamList = teams;
            matchDetails.StadiumsList = stadiums;
            matchDetails.LeaguesList = leagues;

            return View(matchDetails);
        }
    }
}