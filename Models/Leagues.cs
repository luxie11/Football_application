using System;
using System.Collections.Generic;

namespace FootballApplication.Models
{
    public partial class Leagues
    {
        public Leagues()
        {
            LeagueTeams = new HashSet<LeagueTeams>();
            Matches = new HashSet<Matches>();
        }

        public int IdLeagues { get; set; }
        public string Name { get; set; }
        public int? NumberOfClubs { get; set; }
        public string Founded { get; set; }

        public virtual ICollection<LeagueTeams> LeagueTeams { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
