using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballApplication.Models
{
    public partial class Stadiums
    {
        public Stadiums()
        {
            Matches = new HashSet<Matches>();
        }

        public int IdStadiums { get; set; }
        [Required(ErrorMessage = "Please enter stadium name.")]
        public string Name { get; set; }
        public int? Capacity { get; set; }
        [Required(ErrorMessage = "Please stadium date.")]
        [StringLength(4)]
        public string StadiumOpened { get; set; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Please select home team id.")]
        public int FkHomeTeamsId { get; set; }

        
        public virtual Team FkHomeTeams { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
