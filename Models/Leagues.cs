using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Please enter league name.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter number of clubs.")]
        public int? NumberOfClubs { get; set; }

        [Required(ErrorMessage = "Please enter league years of foundation.")]
        public string Founded { get; set; }

        public virtual ICollection<LeagueTeams> LeagueTeams { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
