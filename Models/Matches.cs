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

        [Required(ErrorMessage = "Please enter game time.")]
        public DateTime? MatchTime { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select home team id.")]
        public int FkHomeTeamId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select away team id.")]
        public int FkAwayTeamId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select stadium id.")]
        public int FkStadiumsId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select league id.")]
        public int FkLeaguesId { get; set; }

        public virtual Team FkAwayTeam { get; set; }
        public virtual Team FkHomeTeam { get; set; }
        public virtual Leagues FkLeagues { get; set; }
        public virtual Stadiums FkStadiums { get; set; }
    }
}
