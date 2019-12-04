using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballApplication.Models
{
    public partial class Matches
    {
        public int IdMatches { get; set; }
        
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? GameWeek { get; set; }
        [Required]
        [StringLength(20)]
        public DateTime? MatchTime { get; set; }
        [Required]
        public int FkHomeTeamId { get; set; }
        [Required]
        public int FkAwayTeamId { get; set; }
        [Required]
        public int FkStadiumsId { get; set; }
        [Required]
        public int FkLeaguesId { get; set; }

        public virtual Team FkAwayTeam { get; set; }
        public virtual Team FkHomeTeam { get; set; }
        public virtual Leagues FkLeagues { get; set; }
        public virtual Stadiums FkStadiums { get; set; }
    }
}
