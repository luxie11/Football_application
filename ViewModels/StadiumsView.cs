using FootballApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class StadiumsView
    {
        public List<StadiumDetails> stadiums { get; set; }
        public List<Team> team { get; set; }
        public Stadiums stadium { get; set; }
    }
}
