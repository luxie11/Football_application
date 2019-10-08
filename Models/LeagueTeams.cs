using System;
using System.Collections.Generic;

namespace FootballApplication.Models
{
    public partial class LeagueTeams
    {
        public int IdLeagueTeams { get; set; }
        public int? MatchesPlayed { get; set; }
        public int? Wins { get; set; }
        public int? Draws { get; set; }
        public int? Loses { get; set; }
        public int? GoalsScored { get; set; }
        public int? GoalsConceded { get; set; }
        public int? Points { get; set; }
        public string Years { get; set; }
        public int FkTeamId { get; set; }
        public int FkLeaguesId { get; set; }

        public virtual Leagues FkLeagues { get; set; }
        public virtual Team FkTeam { get; set; }
    }
}
