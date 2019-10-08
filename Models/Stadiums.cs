using System;
using System.Collections.Generic;

namespace FootballApplication.Models
{
    public partial class Stadiums
    {
        public Stadiums()
        {
            Matches = new HashSet<Matches>();
        }

        public int IdStadiums { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public string StadiumOpened { get; set; }
        public int FkHomeTeamsId { get; set; }

        public virtual Team FkHomeTeams { get; set; }
        public virtual ICollection<Matches> Matches { get; set; }
    }
}
