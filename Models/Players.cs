using System;
using System.Collections.Generic;

namespace FootballApplication.Models
{
    public partial class Players
    {
        public int IdPlayers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int? KitNumber { get; set; }
        public string Nationality { get; set; }
        public int FkPlayerTeam { get; set; }
        public virtual Team FkPlayerTeamNavigation { get; set; }
    }

}
