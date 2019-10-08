using System;
using System.Collections.Generic;

namespace FootballApplication.Models
{
    public partial class Team
    {
        public Team()
        {
            LeagueTeams = new HashSet<LeagueTeams>();
            MatchesFkAwayTeam = new HashSet<Matches>();
            MatchesFkHomeTeam = new HashSet<Matches>();
            Players = new HashSet<Players>();
            Stadiums = new HashSet<Stadiums>();
        }

        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public string Founded { get; set; }
        public string CrestUrl { get; set; }
        public string ClubColors { get; set; }

        public virtual ICollection<LeagueTeams> LeagueTeams { get; set; }
        public virtual ICollection<Matches> MatchesFkAwayTeam { get; set; }
        public virtual ICollection<Matches> MatchesFkHomeTeam { get; set; }
        public virtual ICollection<Players> Players { get; set; }
        public virtual ICollection<Stadiums> Stadiums { get; set; }
    }
}
