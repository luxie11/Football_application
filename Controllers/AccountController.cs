using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FootballApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly footballappContext _context;

        public AccountController(footballappContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(object sender, EventArgs e)
        {
            string username = String.Format("{0}", Request.Form["username"]);
            string password = Request.Form["password"];
            string cypheredPassword = cypherPassword(password);
            var userDetails = _context.Users
                .Select(el => new { el.Username, el.Role, el.Password })
                .Where(u => u.Password.Equals(cypheredPassword) && u.Username.ToLower().Equals(username.ToLower()))
                .FirstOrDefault();
            if (userDetails != null)
            {
                HttpContext.Session.Set("Username", Encoding.ASCII.GetBytes(username));
                HttpContext.Session.Set("IsUserConnected", BitConverter.GetBytes(1));
                HttpContext.Session.Set("UserRole", BitConverter.GetBytes(userDetails.Role));
                return Redirect("/");
            }
            if (username.Length == 0)
                ViewData["UsernameError"] = "Please enter username";
            if (password.Length == 0)
                ViewData["PasswordError"] = "Please enter password";
            if (userDetails == null && password.Length != 0 && username.Length != 0)
                ViewData["UserError"] = "Please enter correct details";
            return View("Index");
        }

        public IActionResult Logout(object sender, EventArgs e)
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

        public string cypherPassword(string password)
        {
            byte[] passwordByteArray = Encoding.ASCII.GetBytes(password);
            SHA1 sha1Algorithm = new SHA1CryptoServiceProvider();
            byte[] cypheredPasswordArray = sha1Algorithm.ComputeHash(passwordByteArray);
            string cypheredPassword = String.Concat(cypheredPasswordArray.Select(el => el.ToString("x2")));
            return cypheredPassword;
        }
    }
}