using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.HelperClasses
{
    public class PlayersDetails
    {
        public int IdPlayers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int? KitNumber { get; set; }
        public string Nationality { get; set; }
        public string ClubName { get; set; }
    }
}
