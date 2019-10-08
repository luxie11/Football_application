using FootballApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class TeamDetails
    {
        public List<Players> Players { get; set; }
        public List<Team> Team { get; set; }
    }
}
