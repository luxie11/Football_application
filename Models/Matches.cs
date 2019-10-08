using System;
using System.Collections.Generic;

namespace FootballApplication.Models
{
    public partial class Matches
    {
        public int IdMatches { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? GameWeek { get; set; }
        public DateTime? MatchTime { get; set; }
        public int FkHomeTeamId { get; set; }
        public int FkAwayTeamId { get; set; }
        public int FkStadiumsId { get; set; }
        public int FkLeaguesId { get; set; }

        public virtual Team FkAwayTeam { get; set; }
        public virtual Team FkHomeTeam { get; set; }
        public virtual Leagues FkLeagues { get; set; }
        public virtual Stadiums FkStadiums { get; set; }
    }
}
