using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class LeagueTableDetails
    {
        public int leagueID { get; set; }
        public int teamID { get; set; }
        public string teamCrest { get; set; }
        public string teamName { get; set; }
        public int? matchesPlayed { get; set; }
        public int? wins { get; set; }
        public int? draws { get; set; }
        public int? loses { get; set; }
        public int? goalsScored { get; set; }
        public int? goalsConceded { get; set; }
        public int? goalsDifference { get; set; }
        public int? points { get; set; }

    }
}
