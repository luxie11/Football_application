using FootballApplication.HelperClasses;
using FootballApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class PlayersView
    {
        public List<PlayersDetails> players { get; set; }

        public List<Team> teams { get; set; }

        public Players player { get; set; }
    }
}
