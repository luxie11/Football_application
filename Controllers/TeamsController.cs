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

        public async Task<IActionResult> Index(int id)
        {
            TeamDetails teamDetails = new TeamDetails();
            teamDetails.Players = await (from player in _context.Players
                                       join team in _context.Team on player.FkPlayerTeam equals team.IdTeam
                                       select player)
                                       .Where(item => item.FkPlayerTeam == id)
                                       .ToListAsync();
            var stadiumName = _context.Stadiums.Select(col => new { col.FkHomeTeamsId, col.Name }).Where(el => el.FkHomeTeamsId == id).FirstOrDefault();
            teamDetails.stadiumName = stadiumName.Name.ToString();

            var teamInformation = _context.Team
                                .Select(col => new { col.IdTeam, col.TeamName, col.ClubColors, col.CrestUrl, col.Founded })
                                .Where(el => el.IdTeam == id)
                                .FirstOrDefault();
            teamDetails.crestUrl = teamInformation.CrestUrl;
            teamDetails.teamName = teamInformation.TeamName;
            teamDetails.founded = teamInformation.Founded;
            teamDetails.clubColors = teamInformation.ClubColors;

            var clubFinishedMatches = await (from matches in _context.Matches
                                    join homeTeam in _context.Team on matches.FkHomeTeamId equals homeTeam.IdTeam
                                    join awayTeam in _context.Team on matches.FkAwayTeamId equals awayTeam.IdTeam
                                    select new Tuple<string, int?, int, string, int?, int, DateTime?>
                                    (
                                        homeTeam.TeamName,
                                        matches.HomeTeamScore,
                                        matches.FkHomeTeamId,
                                        awayTeam.TeamName,
                                        matches.AwayTeamScore,
                                        matches.FkAwayTeamId,
                                        matches.MatchTime
                                    ))
                .Where(el => (el.Item3 == id || el.Item6 == id) && DateTime.Compare(el.Item7.Value.Date, DateTime.Now.Date) < 0)
                .OrderByDescending(x => x.Item7)
                .Take(5)
                .ToListAsync();
            var clubNextMatches = await (from matches in _context.Matches
                                        join homeTeam in _context.Team on matches.FkHomeTeamId equals homeTeam.IdTeam
                                        join awayTeam in _context.Team on matches.FkAwayTeamId equals awayTeam.IdTeam
                                        select new Tuple<string, int?, int, string, int?, int, DateTime?>
                                        (
                                            homeTeam.TeamName,
                                            matches.HomeTeamScore,
                                            matches.FkHomeTeamId,
                                            awayTeam.TeamName,
                                            matches.AwayTeamScore,
                                            matches.FkAwayTeamId,
                                            matches.MatchTime
                                        ))
            .Where(el => (el.Item3 == id || el.Item6 == id) && 
                         (DateTime.Compare(el.Item7.Value.Date, DateTime.Now.Date) > 0 || DateTime.Compare(el.Item7.Value.Date, DateTime.Now.Date) == 0))
            .OrderBy(x => x.Item7)
            .Take(5)
            .ToListAsync();

            teamDetails.finishedMatches = clubFinishedMatches;
            teamDetails.nextMatches = clubNextMatches;
            return View(teamDetails);
        }
    }
}