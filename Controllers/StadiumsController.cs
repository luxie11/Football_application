using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FootballApplication.HelperClasses;
using FootballApplication.Models;
using FootballApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballApplication.Controllers
{
    public class StadiumsController : Controller
    {
        private readonly footballappContext _context;

        public StadiumsController(footballappContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var stadiums = await (from stadium in _context.Stadiums
                                      join team in _context.Team on stadium.FkHomeTeamsId equals team.IdTeam
                                      select new StadiumDetails
                                      {
                                          IdStadiums = stadium.IdStadiums,
                                          Name = stadium.Name,
                                          Capacity = stadium.Capacity,
                                          StadiumOpened = stadium.StadiumOpened,
                                          TeamName = team.TeamName
                                      })
                                  .ToListAsync();
                StadiumsView stadiumView = new StadiumsView();
                stadiumView.stadiums = stadiums;
                return View(stadiumView);
            }
            return RedirectToAction("Index", "Matches");
        }

        [HttpGet]
        public async Task<IActionResult> Insert(object sender, EventArgs e)
        {
            List<Team> team = await _context.Team.ToListAsync();
            StadiumsView stadiumView = new StadiumsView();
            stadiumView.team = team;
            return View(stadiumView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert()
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                string stadiumName = Request.Form["StadiumName"];
                string capacity = Request.Form["Capacity"];
                string stadiumOpened = Request.Form["StadiumOpened"];
                string homeTeamId = Request.Form["HomeTeamId"];
                Stadiums stadium = new Stadiums();
                var stadiumsCount = _context.Stadiums.Count() + 2;
                stadium.IdStadiums = stadiumsCount++;
                stadium.Name = stadiumName;
                stadium.Capacity = !capacity.Equals("") ? Int32.Parse(capacity.Trim()) : 0;
                stadium.StadiumOpened = stadiumOpened;
                stadium.FkHomeTeamsId = !homeTeamId.Equals("") ? Int32.Parse(homeTeamId.Trim()) : 0;
                TryValidateModel(stadium);
                if (ModelState.IsValid)
                {
                    _context.Add(stadium);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "Stadium was succesfully inserted!";
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
                    TempData["ActionError"] = errors as IEnumerable<string>;
                }
            }
            return Redirect("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var stadium = _context.Stadiums
                    .Where(el => el.IdStadiums == id)
                    .FirstOrDefault();
                _context.Remove(stadium);
                await _context.SaveChangesAsync();
                TempData["ActionSuccess"] = "Stadium was succesfully deleted!";
            }
            else
            {
                TempData["ActionError"] = "ERROR! You don't have perimissions.";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id, object sender, EventArgs e)
        {
            StadiumsView stadiumView = new StadiumsView();
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var stadiumInformation = _context.Stadiums.Where(el => el.IdStadiums == id).FirstOrDefault();
                stadiumView.team = await _context.Team.ToListAsync();
                stadiumView.stadium = stadiumInformation;
            }
            return View(stadiumView);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                string capacity = Request.Form["Capacity"];
                string stadiumOpened = Request.Form["StadiumOpened"];
                string homeTeamId = Request.Form["stadium.FkHomeTeamsId"];
                Stadiums stadiums = new Stadiums();
                stadiums.IdStadiums = id;
                stadiums.Name = Request.Form["StadiumName"];
                stadiums.Capacity = !capacity.Equals("") ? Int32.Parse(capacity.Trim()) : 0;
                stadiums.StadiumOpened = stadiumOpened;
                stadiums.FkHomeTeamsId = !homeTeamId.Equals("") ? Int32.Parse(homeTeamId) : 0;
                TryValidateModel(stadiums);
                if (ModelState.IsValid)
                {
                    _context.Update(stadiums);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "Match was succesfully updated!";
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