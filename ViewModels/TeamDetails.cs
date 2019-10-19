using FootballApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class TeamDetails
    {
        public List<Players> Players { get; set; }
        public List<Tuple<string, int?, int, string, int?, int, DateTime?>> finishedMatches { get; set; }
        public List<Tuple<string, int?, int, string, int?, int, DateTime?>> nextMatches { get; set; }
        public int leagueID { get;set; }
        public string stadiumName { get; set; }
        public string teamName { get; set; }
        public string clubColors { get; set; }
        public string crestUrl { get; set; }
        public string founded { get; set; }
    }

    public enum PlayerPosition
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Attacker
    }
}
