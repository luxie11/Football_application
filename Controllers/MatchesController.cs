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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert()
        {
            string leagueId = Request.Form["league"];
            string homeTeamId = Request.Form["homeTeam"];
            string homeTeamScore = Request.Form["homeTeamScore"];
            string awayTeamId = Request.Form["awayTeam"];
            string awayTeamScore = Request.Form["awayTeamScore"];
            string gameweek = Request.Form["gameweek"];
            string gametime = Request.Form["gameTime"];
            string stadiumId = Request.Form["stadium"];
            Matches match = new Matches();
            if (!homeTeamId.Equals(awayTeamId))
            {
                var matchesCount = _context.Matches.Count();
                match.IdMatches = matchesCount + 2;
                match.FkHomeTeamId = int.Parse(homeTeamId);
                match.FkAwayTeamId = Int32.Parse(awayTeamId);
                match.FkLeaguesId = !leagueId.Equals("") ? Int32.Parse(leagueId) : 0;
                match.FkStadiumsId = !stadiumId.Equals("") ? Int32.Parse(stadiumId) : 0;
                match.HomeTeamScore = !homeTeamScore.Equals("") ? Int32.Parse(homeTeamScore.Trim()) : 0;
                match.AwayTeamScore = !awayTeamScore.Equals("") ? Int32.Parse(awayTeamScore.Trim()) : 0;
                match.GameWeek = !gameweek.Equals("") ? Int32.Parse(gameweek.Trim()) : 0;
                match.FkLeaguesId = !leagueId.Equals("") ? Int32.Parse(leagueId) : 0;
                match.MatchTime = gametime.Equals("") ? Convert.ToDateTime(gametime.ToString()) : DateTime.MinValue;
                
                TryValidateModel(match);
                if (ModelState.IsValid)
                {
                    _context.Add(match);
                    await _context.SaveChangesAsync();
                    TempData["InsertSuccess"] = "Match was succesfully inserted!";
                } else
                {
                    var errors = new List<string>();
                    foreach(var modelState in ModelState.Values)
                    {
                        foreach(var modelError in modelState.Errors)
                        {
                            errors.Add(modelError.ErrorMessage);
                        }
                    }
                    TempData["ErrorMessage"] = errors as IEnumerable<string>;
                }
            }
            
            if(homeTeamId.Equals(awayTeamId))
            {
                TempData["ActionError"] = "ERROR! Home team and away team are the same index.";
            }
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var matches = _context.Matches
                          .Where(el => el.IdMatches == id)
                          .FirstOrDefault();
                _context.Remove(matches);
                await _context.SaveChangesAsync();
                TempData["ActionSuccess"] = "Match was succesfully deleted!";
            }
            else
            {
                TempData["ActionError"] = "ERROR! You don't have perimissions.";
            }
            return Redirect("/");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            MatchDetails matchDetails = new MatchDetails();
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var matchInformation = _context.Matches.Where(x => x.IdMatches == id).SingleOrDefault();
                matchDetails.matches = matchInformation;
                List<Team> teams = await _context.Team.ToListAsync();
                List<Stadiums> stadiums = await _context.Stadiums.ToListAsync();
                List<Leagues> leagues = await _context.Leagues.ToListAsync();
                matchDetails.TeamList = teams;
                matchDetails.StadiumsList = stadiums;
                matchDetails.LeaguesList = leagues;
            }
            return View(matchDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            string leagueId = Request.Form["matches.FkLeaguesId"];
            string homeTeamId = Request.Form["matches.FkHomeTeamId"];
            string homeTeamScore = Request.Form["homeTeamScore"];
            string awayTeamId = Request.Form["matches.FkAwayTeamId"];
            string awayTeamScore = Request.Form["awayTeamScore"];
            string gameweek = Request.Form["gameweek"];
            string gametime = Request.Form["gameTime"];
            string stadiumId = Request.Form["matches.FkStadiumsId"];
            Matches match = new Matches();
            match.IdMatches = id;
            match.FkHomeTeamId = int.Parse(homeTeamId);
            match.FkAwayTeamId = Int32.Parse(awayTeamId);
            match.FkLeaguesId = !leagueId.Equals("") ? Int32.Parse(leagueId) : 0;
            match.FkStadiumsId = !stadiumId.Equals("") ? Int32.Parse(stadiumId) : 0;
            match.HomeTeamScore = !homeTeamScore.Equals("") ? Int32.Parse(homeTeamScore.Trim()) : 0;
            match.AwayTeamScore = !awayTeamScore.Equals("") ? Int32.Parse(awayTeamScore.Trim()) : 0;
            match.GameWeek = !gameweek.Equals("") ? Int32.Parse(gameweek.Trim()) : 0;
            match.FkLeaguesId = !leagueId.Equals("") ? Int32.Parse(leagueId) : 0;
            match.MatchTime = gametime.Equals("") ? Convert.ToDateTime(gametime.ToString()) : DateTime.MinValue;
            TryValidateModel(match);
            if (ModelState.IsValid)
            {
                _context.Update(match);
                await _context.SaveChangesAsync();
            }
            else
            {

            }
            return Redirect("/");
        }
    }
}