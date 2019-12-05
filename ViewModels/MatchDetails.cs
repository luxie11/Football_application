using FootballApplication.HelperClasses;
using FootballApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class MatchDetails
    {
        public X.PagedList.IPagedList<HeadToHeadMatches> HeadToHeadMatches { get; set; }
        public List<Team> TeamList { get; set; }
        public List<Stadiums> StadiumsList { get; set; }
        public List<Leagues> LeaguesList { get; set; }

        public Matches matches { get; set; }
    }
}
