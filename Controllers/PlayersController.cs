using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballApplication.HelperClasses;
using FootballApplication.Models;
using FootballApplication.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballApplication.Controllers
{
    public class PlayersController : Controller
    {
        private readonly footballappContext _context;

        public PlayersController(footballappContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            PlayersView playersView = new PlayersView();
            var players = await (from player in _context.Players
                                 join team in _context.Team on player.FkPlayerTeam equals team.IdTeam
                                 select new PlayersDetails
                                 {
                                     IdPlayers = player.IdPlayers,
                                     FirstName = player.FirstName,
                                     LastName = player.LastName,
                                     Position = player.Position,
                                     KitNumber = player.KitNumber,
                                     Nationality = player.Nationality,
                                     ClubName = team.TeamName
                                 }).ToListAsync();
            playersView.players = players;
            return View(playersView);
        }

        [HttpGet]
        public async Task<IActionResult> Insert(object sender, EventArgs e)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                List<Team> teamsList = await _context.Team.ToListAsync();
                PlayersView playersView = new PlayersView();
                playersView.teams = teamsList;
                return View(playersView);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Insert()
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                int playerCount = _context.Players.Count() + 2;
                string kitNumber = Request.Form["KitNumber"];
                string clubId = Request.Form["TeamID"];
                Players player = new Players();
                player.IdPlayers = playerCount;
                player.FirstName = Request.Form["Firstname"];
                player.LastName = Request.Form["Lastname"];
                player.Position = Request.Form["Position"];
                player.KitNumber = !kitNumber.Equals("") ? Int32.Parse(kitNumber) : 0;
                player.Nationality = Request.Form["Nationality"];
                player.FkPlayerTeam = !clubId.Equals("") ? Int32.Parse(clubId) : 0;
                TryValidateModel(player);
                if (ModelState.IsValid)
                {
                    _context.Add(player);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "Player was succesfully inserted!";
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
                return RedirectToAction("Index");
            }
            TempData["ActionError"] = "ERROR! You don't have perimissions.";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                var player = _context.Players
                            .Where(el => el.IdPlayers == id)
                            .FirstOrDefault();
                _context.Remove(player);
                await _context.SaveChangesAsync();
                TempData["ActionSuccess"] = "Player was succesfully deleted!";
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
            PlayersView playersView = new PlayersView();
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {

                List<Team> team = await _context.Team.ToListAsync();
                playersView.teams = team;
                playersView.player = _context.Players.Where(el => el.IdPlayers == id).FirstOrDefault();
            }
            return View(playersView);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id)
        {
            int userRoleNumber = HttpContext.Session.Get("UserRole") != null ? BitConverter.ToInt16(HttpContext.Session.Get("UserRole")) : 0;
            if (userRoleNumber == 1)
            {
                string kitNumber = Request.Form["KitNumber"];
                string clubId = Request.Form["player.FkPlayerTeam"];
                Players player = new Players();
                player.IdPlayers = id;
                player.FirstName = Request.Form["Firstname"];
                player.LastName = Request.Form["Lastname"];
                player.Position = Request.Form["Position"];
                player.KitNumber = !kitNumber.Equals("") ? Int32.Parse(kitNumber) : 0;
                player.Nationality = Request.Form["Nationality"];
                player.FkPlayerTeam = !clubId.Equals("") ? Int32.Parse(clubId) : 0;
                TryValidateModel(player);
                if (ModelState.IsValid)
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                    TempData["ActionSuccess"] = "Player was succesfully updated!";
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
            else
            {
                TempData["ActionError"] = "ERROR! You don't have perimissions.";
            }
            return RedirectToAction("Index");
        }
    }
}