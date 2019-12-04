using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballApplication.HelperClasses;
using FootballApplication.Models;
using FootballApplication.ViewModels;
using Microsoft.AspNetCore.Http;
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
                            }).OrderBy(model => model.matchTime)
                            .ToListAsync();
          
            MatchDetails matchDetails = new MatchDetails();

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            matchDetails.HeadToHeadMatches = matchesList.ToPagedList(pageNumber, pageSize);

            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if(userRoleNumber == 1)
            {
                List<Team> teams = await _context.Team.ToListAsync();
                List<Stadiums> stadiums = await _context.Stadiums.ToListAsync();
                List<Leagues> leagues = await _context.Leagues.ToListAsync();
                matchDetails.TeamList = teams;
                matchDetails.StadiumsList = stadiums;
                matchDetails.LeaguesList = leagues;
            }
            return View(matchDetails);
        }

        public async Task<IActionResult> Insert(object sender, EventArgs e)
        {
            string leagueId = Request.Form["stadium"];
            string homeTeamId = Request.Form["homeTeam"];
            string homeTeamScore = Request.Form["homeTeamScore"];
            string awayTeamId = Request.Form["awayTeam"];
            string awayTeamScore = Request.Form["awayTeamScore"];
            string gameweek = Request.Form["gameweek"];
            string gametime = Request.Form["gameTime"];
            string stadiumId = Request.Form["stadium"];

            //Sugalvoti su ID rungtyniu!!!!!!
            Matches match = new Matches();
            match.IdMatches = 1200;
            match.FkLeaguesId = Int32.Parse(leagueId);
            match.FkHomeTeamId = Int32.Parse(homeTeamId);
            match.HomeTeamScore = Int32.Parse(homeTeamScore);
            match.FkAwayTeamId = Int32.Parse(awayTeamId);
            match.AwayTeamScore = Int32.Parse(awayTeamScore);
            match.GameWeek = Int32.Parse(gameweek);
            match.MatchTime = DateTime.Parse(gametime);
            match.FkStadiumsId = Int32.Parse(stadiumId);

            if (!homeTeamId.Equals(awayTeamId))
            {
                _context.Add(match);
                await _context.SaveChangesAsync();
            }

            return Redirect("/");
        }
    }
}