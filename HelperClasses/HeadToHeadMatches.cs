using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.HelperClasses
{
    public class HeadToHeadMatches
    {
        public int id { get; set; }
        public DateTime? matchTime { get; set; }
        public string homeTeamName { get; set; }
        public string homeTeamCrest { get; set; }
        public int? homeTeamScore { get; set; }
        public string awayTeamName { get; set; }
        public string awayTeamCrest { get; set; }
        public int? awayTeamScore { get; set; }
        public int? gameWeek { get; set; }
    }
}
