using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballApplication.Models;
using FootballApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballApplication.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly footballappContext _context;

        public LeaguesController(footballappContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            LeagueView leagueView = new LeagueView();
            var leaguesList = await _context.Leagues.ToListAsync();
            leagueView.leagues = leaguesList;

            return View(leagueView);
        }

        [HttpGet]
        public async Task<IActionResult> Insert(object sender, EventArgs e)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert()
        {
            Leagues league = new Leagues();
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                int leaguesCount = _context.Leagues.Count() + 2;
                string numberOfClubs = Request.Form["NumberOfClubs"];
                league.IdLeagues = leaguesCount;
                league.NumberOfClubs = !numberOfClubs.Equals("") ? Int32.Parse(numberOfClubs) : 0;
                league.Name = Request.Form["Name"];
                league.Founded = Request.Form["Founded"];
                TryValidateModel(league);
                if (ModelState.IsValid)
                {
                    _context.Add(league);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "League was succesfully inserted!";
                }
                else
                {
                    var errors = new List<string>();
                    foreach (var modelState in ModelState.Values)
                    {
                        foreach (var modelError in modelState.Errors)
                        {
                            errors.Add(modelError.ErrorMessage);
                        }
                    }
                    TempData["ErrorMessage"] = errors as IEnumerable<string>;
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var league = _context.Leagues
                            .Where(el => el.IdLeagues == id)
                            .FirstOrDefault();
                int countLeagueAssociations = _context.LeagueTeams.Where(el => el.FkLeaguesId == id).Count();
                if(countLeagueAssociations != 0)
                {
                    _context.Remove(league);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "League was succesfully deleted!";
                }
                else
                {
                    TempData["ActionError"] = "Can't delete league, because it has tables with teams!";
                }
            }
            else
            {
                TempData["ActionError"] = "ERROR! You don't have perimissions.";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            LeagueView leagueView = new LeagueView();
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var leagueInformation = _context.Leagues.Where(el => el.IdLeagues == id).FirstOrDefault();
                return View(leagueInformation);
            }
            TempData["ActionError"] = "ERROR! You don't have perimissions.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("IdLeagues, Name, NumberOfClubs, Founded")] Leagues league)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                league.IdLeagues = id;
                TryValidateModel(league);
                if (ModelState.IsValid)
                {
                    _context.Update(league);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "League was succesfully Updated!";
                }
                else
                {
                    var errors = new List<string>();
                    foreach (var modelState in ModelState.Values)
                    {
                        foreach (var modelError in modelState.Errors)
                        {
                            errors.Add(modelError.ErrorMessage);
                        }
                    }
                    TempData["ErrorMessage"] = errors as IEnumerable<string>;
                }
            }
            return RedirectToAction("Index");
        }
    }
}