using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApplication.ViewModels
{
    public class StadiumDetails
    {
        public int IdStadiums { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public string StadiumOpened { get; set; }
        public string TeamName { get; set; }
    }
}
