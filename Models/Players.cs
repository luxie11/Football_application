using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballApplication.Models
{
    public partial class Players
    {

        public int IdPlayers { get; set; }
        [Required(ErrorMessage = "Please enter player firstname.")]
        [StringLength(80)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter player lastname.")]
        [StringLength(80)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter player position.")]
        [StringLength(50)]
        public string Position { get; set; }
        [Required(ErrorMessage = "Please enter player kit number.")]
        public int? KitNumber { get; set; }
        [Required(ErrorMessage = "Please enter player nationality.")]
        [StringLength(80)]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "Please select player club.")]
        public int FkPlayerTeam { get; set; }
        public virtual Team FkPlayerTeamNavigation { get; set; }
    }

}
